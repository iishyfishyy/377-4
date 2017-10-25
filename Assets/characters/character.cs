﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character{

	public int mana;
	public int health;
	public int damage;
	public string type;

	// Use this for initialization
	void Start () {
		this.mana = 0;
		this.health = 0;
	}

	// Update is called once per frame


	public abstract int damage_dealt (Character character);


	//Function to get random number
	private static readonly System.Random getrandom = new System.Random();
	private static readonly object syncLock = new object();
	public int GetRandomNumber(int min, int max)
	{
		lock(syncLock) { // synchronize
			return getrandom .Next(min, max);
		}
	}



	/*Joefa*/

	/*Joefa*/
}
