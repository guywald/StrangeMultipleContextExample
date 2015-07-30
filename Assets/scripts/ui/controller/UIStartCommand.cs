using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

namespace com.example.jumpergame.ui
{
	public class UIStartCommand : Command
	{
		public override void Execute ()
		{
			Debug.Log ("UI Started!");
		}
	}
}