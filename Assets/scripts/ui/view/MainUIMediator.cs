using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

namespace com.example.jumpergame.ui
{
	public class MainUIMediator : Mediator
	{
		[Inject]
		public MainUIView view { get; set; }

		[Inject]
		public JumpButtonClickedSignal jumpButtonClickedSignal { get; set; }

		[Inject]
		public UpdateScoreSignal updateScoreSignal { get; set; }

		public override void OnRegister ()
		{
			base.OnRegister ();
			view.buttonClicked.AddListener(jump);
			updateScoreSignal.AddListener(updateScore);
		}

		public override void OnRemove ()
		{
			base.OnRemove ();
			updateScoreSignal.RemoveListener(updateScore);
			view.buttonClicked.RemoveListener(jump);
		}


		void updateScore(int score)
		{
			view.jumpsCounter.text = score.ToString();
		}

		void jump() 
		{
			Debug.Log ("Dispatching JumpButtonClickedSignal");
			jumpButtonClickedSignal.Dispatch();
		}
	}
}