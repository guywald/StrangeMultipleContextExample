using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace com.example.jumpergame.game
{
	[MediatedBy(typeof(JumperMediator))]
	public class JumperView : View
	{
		internal Signal jumpedSignal = new Signal ();


		internal void Init()
		{
			Debug.Log ("Jumper view init");
		}

		public void Jump ()
		{
			gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(100f,100f,100f));
			jumpedSignal.Dispatch();
		}
	}
}