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
		this.receive_damage ();

		this.health -= this.damage;
		base.Update ();
	}

	protected override int damage_dealt (){
		foreach (var item in allies) {
			if (item.GetType ().Equals ("Warrior")) {
				item.health -= GetRandomNumber (45, 55);
			} else {
				item.health += GetRandomNumber (5, 20);
			}
		}
		return GetRandomNumber (5, 20);
	}

	private void receive_damage(){
		foreach (var item in allies) {
			this.health -= item.damage;
		}
	}




	/*Joefa*/

	/*Joefa*/
}
