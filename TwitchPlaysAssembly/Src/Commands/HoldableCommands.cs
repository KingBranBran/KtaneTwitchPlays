﻿using System.Collections;

/// <summary>Contains commands for holdables (including the freeplay case and the missions binder).</summary>
public static class HoldableCommands
{
	#region Commands
	[Command("(hold|pick up)")]
	public static IEnumerator Hold(TwitchHoldable holdable) => holdable.Hold();

	[Command("(drop|let go|put down)")]
	public static IEnumerator Drop(TwitchHoldable holdable) => holdable.Drop();

	[Command(@"(turn|turn round|turn around|rotate|flip|spin)")]
	public static IEnumerator Flip(TwitchHoldable holdable) => holdable.Turn();

	[Command(null)]
	public static IEnumerator DefaultCommand(TwitchHoldable holdable, string user, bool isWhisper, string cmd) => holdable.RespondToCommand(user, cmd, isWhisper);
	#endregion
}