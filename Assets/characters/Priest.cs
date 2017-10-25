using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : Character {

	// Use this for initialization
	void Start () {
		this.health = 1000;
		this.mana = 1000;
		this.damage = this.damage_dealt ();
		allies.Add (this);
	}

	// Update is called once per frame
	void Update () {
		this.small_heal ();
		this.big_heal ();
		this.regenerate_mana ();
	}


	private void regenerate_mana (){
		this.mana -= 2;
	}

	// Heals damage dealer or priest per time-step
	private void small_heal(){

		// heals healer in if else heals random damage-dealer
		if (!(this.GetRandomNumber (0, 2) == 2)) {
			this.health += 15;
			this.mana -= 5;
		} else {
			int num_of_damage_dealers = 0;

			foreach (var item in allies) {
				if (!item.GetType ().Equals ("Warrior"))
					num_of_damage_dealers++;
			}

			int character_getting_healed = this.GetRandomNumber (0, num_of_damage_dealers);

			int counter = 0;
			foreach (var item in allies) {
				if (!item.GetType ().Equals ("Warrior")) {
					if (counter == character_getting_healed) {
						item.health += 15;
						this.mana -= 5;
						break;
					} else {
						counter++;
					}
				}
			}
		}
	}

	// Heals tanks
	private void big_heal (){
		foreach (var item in allies) {
			if (item.GetType ().Equals ("Warrior")) {
				item.health += 20;
				this.mana -= 8;
			}
				
		}
	}
	

	protected override int damage_dealt (){
		return 0;
	}


	/*Joefa*/

	/*Joefa*/
}
