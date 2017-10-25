using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character {

	// Use this for initialization
	void Start () {
		this.health = 3000;
		this.mana = 0;
		this.damage = this.damage_dealt ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected override int damage_dealt (){
		return 5;
	}


	/*Joefa*/

	/*Joefa*/
}
