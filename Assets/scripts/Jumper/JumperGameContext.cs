using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;

namespace com.example.jumpergame.game
{
	public class JumperGameContext : MVCSContext
	{

		public JumperGameContext (MonoBehaviour contextView) : base(contextView)
		{
			
		}

		protected override void addCoreComponents ()
		{
			base.addCoreComponents ();
			injectionBinder.Unbind<ICommandBinder> ();
			injectionBinder.Bind<ICommandBinder> ().To<SignalCommandBinder> ().ToSingleton ();
		}
		
		public override void Launch ()
		{
			base.Launch ();
			JumperStartSignal startSignal = (JumperStartSignal)injectionBinder.GetInstance<JumperStartSignal>();
			startSignal.Dispatch();
		}

		protected override void mapBindings ()
		{
			base.mapBindings ();
			implicitBinder.ScanForAnnotatedClasses(new string[]{"com.example.jumpergame.game"});
			injectionBinder.Bind<IGameModel>().To<GameModel>().ToSingleton();

			if (Context.firstContext == this) {
				injectionBinder.Bind<JumpSignal>().ToSingleton();
				injectionBinder.Bind<UpdatedJumpCountSignal>().ToSingleton();
			}

			// first signal
			commandBinder.Bind<JumperStartSignal> ().To<JumperGameStartCommand> ().Once ();

			commandBinder.Bind<JumpedSignal>().To<JumpedCommand>();

		}

		protected override void postBindings ()
		{
			base.postBindings ();
		}
	}
}