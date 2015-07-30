using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;

namespace com.example.jumpergame.ui
{
	public class UIContext : MVCSContext
	{

		public UIContext (MonoBehaviour contextView) : base(contextView)
		{
			
		}

		protected override void addCoreComponents ()
		{
			base.addCoreComponents ();
			injectionBinder.Unbind<ICommandBinder> ();
			injectionBinder.Bind<ICommandBinder> ().To<SignalCommandBinder> ();
		}

		public override void Launch ()
		{
			base.Launch ();
			UIStartSignal uiStartSignal = (UIStartSignal)injectionBinder.GetInstance<UIStartSignal> ();
			uiStartSignal.Dispatch ();
		}

		protected override void mapBindings ()
		{
			base.mapBindings ();

			if (Context.firstContext == this) {
				injectionBinder.Bind<JumpButtonClickedSignal> ().ToSingleton ();
				injectionBinder.Bind<UpdateScoreSignal>().ToSingleton();
			}


			commandBinder.Bind<UIStartSignal> ().To<UIStartCommand> ().Once ();

			#region Mediators

			mediationBinder.BindView<MainUIView> ().ToMediator<MainUIMediator> ();

			#endregion

		}
	}
}