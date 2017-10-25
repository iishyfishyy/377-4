using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : Character {

	// Use this for initialization
	void Start () {
		this.health = 1000;
		this.mana = 1000;
		this.damage = this.damage_dealt ();
	}

	// Update is called once per frame
	void Update () {
		this.small_heal ();
		this.big_heal ();
	}

	private void small_heal(){

	}

	private void big_heal (){

	}

	protected override int damage_dealt (){
		return 0;
	}


	/*Joefa*/

	/*Joefa*/
}
