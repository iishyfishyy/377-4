using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameCharacter : MonoBehaviour{

	public int mana;
	public int health;
	public int damage;
	public string type;
	public static List<GameCharacter> allies = new List<GameCharacter> ();

	// Use this for initialization
	void Start () {
		this.mana = 0;
		this.health = 0;
	}

	public void Update(){
		TextMesh t = (TextMesh)gameObject.GetComponent (typeof(TextMesh));
		if (this.health > 0) {
			t.text = this.GetType () + ": " + this.health;
		} else Application.Quit();
			
		
	}	

	// Update is called once per frame
	public void SetType(string s){
		this.type = s;
	}

	public string GetType(){
		return this.type;
	}

	public abstract int damage_dealt ();


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
