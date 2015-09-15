using UnityEngine;
using System.Collections;

public class SlowDown : Coin {

	public override void PlayerHit(Player _GO)
	{
		base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup.
		myPlayer.m_slowdown = myPlayer.m_slowdown + 0.01f;
	}
}
