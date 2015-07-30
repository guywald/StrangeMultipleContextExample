using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

namespace com.example.jumpergame.game
{
	public class JumperGameStartCommand : Command
	{

//		[Inject(ContextKeys.CONTEXT_VIEW)]
//		public GameObject contextView{get;set;}

		public override void Execute ()
		{
			Debug.Log ("Jumper Game started!");
		}
	}
}