using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;

namespace com.example.jumpergame.ui
{
	public class UIStartSignal : Signal{}

	public class JumpButtonClickedSignal : Signal{}

	public class UpdateScoreSignal : Signal<int>{}
}