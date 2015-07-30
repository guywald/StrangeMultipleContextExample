using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

namespace com.example.jumpergame.main
{
	public class MainStartCommand : Command
	{

//		[Inject(ContextKeys.CONTEXT_VIEW)]
//		public GameObject contextView{get;set;}

		public override void Execute ()
		{
			Debug.Log ("Main started!");
			Application.LoadLevelAdditive("game");
			Application.LoadLevelAdditive("ui");
		}
	}
}