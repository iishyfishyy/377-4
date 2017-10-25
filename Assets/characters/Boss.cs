using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : GameCharacter {
	
	// Use this for initialization
	void Start () {
		this.SetType ("Boss");
		this.health = 4500;
		this.mana = 0;
		this.damage = this.damage_dealt ();
	}

	// Update is called once per frame
	void Update () {
		this.damage = this.damage_dealt ();	
		this.receive_damage ();
		base.Update ();
	}

	public  override int damage_dealt (){
		foreach (GameCharacter c in allies) {
			if (c.GetType().Equals ("Warrior")) {
				c.health -= GetRandomNumber (45, 55);
			} else {
				c.health += GetRandomNumber (5, 20);
			}
		}
		return GetRandomNumber (5, 20);
	}

	private void receive_damage(){
		foreach (GameCharacter item in allies) {
			this.health -= item.damage;
		}
	}
		


	/*Joefa
	public Boss (){
		this.health = 4500;
		this.mana = 0;
		this.type = "boss";
		this.damage = this.GetRandomNumber (5, 20);
	}

	public override int damage_dealt (Character chars){
		if (chars.type.Equals ("warrior")) 
			this.damage = this.GetRandomNumber (45, 55);
		 else 
			this.damage = this.GetRandomNumber (5, 20);

		chars.health -= this.damage;
		return this.damage;
	}


	/*Joefa*/
}
