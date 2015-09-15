using UnityEngine;
using System.Collections;

public class RotatePickUp : Coin {
	
	public override void PlayerHit(Player _GO)
	{
		base.PlayerHit(_GO);//roep de basis classe nog wel aan(dus de playerhit in pickup.
		myPlayer.canIRotate = true;
	}
}
