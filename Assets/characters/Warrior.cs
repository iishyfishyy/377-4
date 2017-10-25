using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Character {

	// Use this for initialization
	/*void Start () {
		this.health = 3000;
		this.mana = 0;
		this.damage = this.damage_dealt ();
		allies.Add (this);

	}
	
	// Update is called once per frame
	void Update () {
		this.damage = this.damage_dealt ();
		this.health -= this.damage;
		base.Update ();
	}*/

	/*protected override int damage_dealt (){
		foreach (var item in allies) {
			if (item.GetType ().Equals ("Warrior")) {
				item.health -= GetRandomNumber (45, 55);
			} else {
				item.health += GetRandomNumber (5, 20);
			}
		}
		return GetRandomNumber (5, 20);
	*/


	/*Joefa*/
	public Warrior (){
		this.health = 3000;
		this.mana = 0;
		this.damage = 5;
		this.type = "warrior";
	}

	public override int damage_dealt (Character boss)
	{
		boss.health -= damage;
		return this.damage;

	}

	/*Joefa*/
}
