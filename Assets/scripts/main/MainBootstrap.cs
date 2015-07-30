using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

namespace com.example.jumpergame.main
{
	public class MainBootstrap : ContextView
	{
		void Awake ()
		{
			context = new MainContext(this);
		}
	}
}