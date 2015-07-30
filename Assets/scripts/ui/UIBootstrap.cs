using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

namespace com.example.jumpergame.ui
{
	public class UIBootstrap : ContextView
	{
		void Awake ()
		{
			context = new UIContext(this);
		}
	}
}