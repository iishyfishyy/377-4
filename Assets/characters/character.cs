using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour{
	public static List<Character> allies;

	public int mana;
	public int health;
	public int damage; 

	// Use this for initialization
	void Start () {
		this.mana = 0;
		this.health = 0;
		this.damage = this.damage_dealt ();
		allies = new List<Character> ();
	}
	
	// Update is called once per frame
	public void Update () {
		TextMesh t = (TextMesh)gameObject.GetComponent (typeof(TextMesh));
		t.text = "Boss: " + this.health.ToString();
	}

	private void add_ally(Character a){
		allies.Add(a);
	}

	private void remove_ally (Character a){
		allies.Remove(a);
	}

	protected abstract int damage_dealt ();


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
