using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;

namespace com.example.jumpergame.main
{
	public class MainContext : MVCSContext
	{
		public MainContext (MonoBehaviour contextView) : base (contextView)
		{
			
		}

		protected override void addCoreComponents ()
		{
			base.addCoreComponents ();
			injectionBinder.Unbind<ICommandBinder>();
			injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>();
		}

		public override void Launch ()
		{
			base.Launch ();
			MainStartSignal mainStartSignal = (MainStartSignal)injectionBinder.GetInstance<MainStartSignal>();
			mainStartSignal.Dispatch();
		}

		protected override void mapBindings ()
		{
			base.mapBindings ();

			commandBinder.Bind<MainStartSignal>().To<MainStartCommand>().Once();

			#region Signals from game
			injectionBinder.Bind<com.example.jumpergame.game.JumpSignal>().ToSingleton().CrossContext();
			injectionBinder.Bind<com.example.jumpergame.game.UpdatedJumpCountSignal>().ToSingleton().CrossContext();
			commandBinder.Bind<com.example.jumpergame.game.UpdatedJumpCountSignal>().To<PlayerJumpedCommand>();
			#endregion

			#region Signals from UI
			injectionBinder.Bind<com.example.jumpergame.ui.UpdateScoreSignal>().ToSingleton().CrossContext();
			injectionBinder.Bind<com.example.jumpergame.ui.JumpButtonClickedSignal> ().ToSingleton ().CrossContext ();
			commandBinder.Bind<com.example.jumpergame.ui.JumpButtonClickedSignal>().To<JumpButtonClickedCommand>();
			#endregion

		}

	}
}