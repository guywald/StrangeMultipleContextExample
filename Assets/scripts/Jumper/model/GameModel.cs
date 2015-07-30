using UnityEngine;
using System.Collections;

namespace com.example.jumpergame.game
{
	public class GameModel : IGameModel
	{

		private int jumps;

		public GameModel ()
		{
			jumps = 0;
		}

		public int JumpCount {
			get {
				return jumps;
			}
		}

		public void Jumped ()
		{
			jumps++;
		}

	}
}