using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Character{

	// Use this for initialization
	/*void Start () {
		this.health = 3000;
		this.mana = 0;
		this.damage = this.damage_dealt ();
	}
	
	// Update is called once per frame
	void Update () {
		this.damage = this.damage_dealt ();	
	}

	protected override int damage_dealt (){
		return this.GetRandomNumber (15,20);
	}*/

	public Rogue (){
		this.health = 3000;
		this.mana = 0;
		this.type = "rogue";
		this.damage = this.GetRandomNumber (15, 20);
	}

	public override int damage_dealt (Character boss){
		this.damage = this.GetRandomNumber(15,20);
		boss.health -= this.damage;
		return this.damage;
	}


}
