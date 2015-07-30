using UnityEngine;
using System.Collections;

namespace com.example.jumpergame.game
{
	public interface IGameModel
	{
		int JumpCount { get; }

		void Jumped ();
	}
}