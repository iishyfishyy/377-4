using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : GameCharacter{

	public Rogue (){
		this.SetType ("Rogue");
		this.health = 3000;
		this.mana = 0;
		this.damage = this.GetRandomNumber (15, 20);
		allies.Add (this);
	}

	void Update () {
		this.damage = this.damage_dealt ();	
		base.Update ();
	}

	public override int damage_dealt (){
		return GetRandomNumber(15,20);
	}


}
