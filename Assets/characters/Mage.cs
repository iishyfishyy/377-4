using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character {

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
	}/*

	protected override int damage_dealt (){
		return this.GetRandomNumber (1,30);
	}


	/*Joefa*/
	public Mage (){
		this.health = 1000;
		this.mana = 0;
		this.type = "mage";
		this.damage = this.GetRandomNumber (1, 30);
	}

	public override int damage_dealt (Character boss)
	{
		this.damage = this.GetRandomNumber (1, 30);
		boss.health -= damage;
		return this.damage;
	}
	/*Joefa*/
	
}
