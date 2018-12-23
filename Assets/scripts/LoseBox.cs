using UnityEngine;
using System.Collections;

public class LoseBox : MonoBehaviour {

public LevelControl levelControl;

	void OnTriggerEnter2D(Collider2D col){
		levelControl.loseGame();
		print ("trigger");
	}
	
	void OnCollisionEnter2D(Collision2D col){
		print ("collision");
	}
}
