using UnityEngine;
using System.Collections;
using strange.extensions.signal.impl;

namespace com.example.jumpergame.game
{
	public class JumperStartSignal : Signal{}

	// Jumper
	public class JumpSignal : Signal{}
	public class JumpedSignal : Signal{}

	public class UpdatedJumpCountSignal : Signal<int> {}
}