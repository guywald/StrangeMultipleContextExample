using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace com.example.jumpergame.ui
{
	public class MainUIView : View
	{
		public Button jumpButton;
		public Text jumpsCounter;

		internal Signal buttonClicked = new Signal();

		internal void Init()
		{
			jumpsCounter.text = "0";
		}

		public void ButtonClicked() 
		{
			buttonClicked.Dispatch();
		}
	}
}