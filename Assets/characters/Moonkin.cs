﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moonkin : Character {

	// Use this for initialization
	/*void Start () {
		this.health = 1000;
		this.mana = 0;
		this.damage = this.damage_dealt ();
		allies.Add (this);

	}

	// Update is called once per frame
	void Update () {
		this.damage = this.damage_dealt ();	
	}

	protected override int damage_dealt (){
		return this.GetRandomNumber (5,15);
	}
	*/
	/*Joefa*/
	public Moonkin (){
		this.health = 1000;
		this.mana = 0;
		this.type = "moonkin";
		this.damage = this.GetRandomNumber (5, 15);
	}

	public override int damage_dealt (Character boss){
		this.damage = this.GetRandomNumber(5,15);
		boss.health -= damage;
		return this.damage;
	}

	/*Joefa*/

}
