using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.example.jumpergame.game
{
	public class JumpedCommand : Command
	{
		[Inject]
		public IGameModel gameModel { get; set; }
		
		[Inject]
		public UpdatedJumpCountSignal updatedJumpcountSignal { get; set; }
		
		public override void Execute ()
		{
			gameModel.Jumped();
			updatedJumpcountSignal.Dispatch(gameModel.JumpCount);
		}
	}
}