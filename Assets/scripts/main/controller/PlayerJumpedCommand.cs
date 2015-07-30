using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.example.jumpergame.main
{
	public class PlayerJumpedCommand : Command
	{
		[Inject]
		public int jumpTimes { get; set; } // from signal

		[Inject]
		public com.example.jumpergame.ui.UpdateScoreSignal updateScoreSignal { get; set; }

		public override void Execute ()
		{
			Debug.Log ("Player jumped");
			updateScoreSignal.Dispatch(jumpTimes);
		}
	}
}