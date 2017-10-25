using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Character {
	
	// Use this for initialization
	void Start () {
		this.health = 4500;
		this.mana = 0;
		this.damage = this.damage_dealt ();
	}

	// Update is called once per frame
	void Update () {
		this.damage = this.damage_dealt ();	
	}

	protected override int damage_dealt (){
		return this.GetRandomNumber (1,30);

	}




	/*Joefa*/

	/*Joefa*/
}
