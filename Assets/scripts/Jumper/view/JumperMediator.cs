using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

namespace com.example.jumpergame.game
{
	public class JumperMediator : Mediator
	{

		[Inject]
		public JumperView view { get; set; }

		[Inject]
		public JumpSignal jumpSignal { get; set; }

		[Inject]
		public JumpedSignal gameJumpedSignal { get; set; }

		public override void OnRegister ()
		{
			base.OnRegister ();
			view.jumpedSignal.AddListener (jumped);
			jumpSignal.AddListener (jump);
		}

		public override void OnRemove ()
		{
			base.OnRemove ();
			jumpSignal.RemoveListener (jump);
			view.jumpedSignal.RemoveListener (jumped);
		}

		void jump ()
		{
			view.Jump();
		}

		void jumped ()
		{
			gameJumpedSignal.Dispatch ();
		}
	}
}