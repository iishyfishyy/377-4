using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public Character warrior;
	public Character boss;
	// Use this for initialization
	void Start () {
		warrior = new Warrior ();
		boss = new Boss ();
	}
	
	// Update is called once per frame
	void Update () {
		if (warrior.health > 0) {
			boss.damage_dealt (warrior);
			Debug.Log ("Damage dealt to warrior: " + boss.damage + "\n" 
				+ "Warrior health " + warrior.health);
			//Debug.Log (warrior.health);
		}
	}
}
