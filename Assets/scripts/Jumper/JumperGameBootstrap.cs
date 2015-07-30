using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;

namespace com.example.jumpergame.game
{
	public class JumperGameBootstrap : ContextView
	{
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView{get;set;}

		// Use this for initialization
		void Awake ()
		{
			context = new JumperGameContext(this);	
		}
	}
}