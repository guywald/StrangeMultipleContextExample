using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.example.jumpergame.main
{
	public class JumpButtonClickedCommand : Command
	{
		[Inject]
		public com.example.jumpergame.game.JumpSignal jumpSignal { get; set; }

		public override void Execute ()
		{
			Debug.Log ("Dispatching jump signal to game");
			jumpSignal.Dispatch();
		}
	}
}