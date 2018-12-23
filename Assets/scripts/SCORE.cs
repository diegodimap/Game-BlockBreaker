using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SCORE : MonoBehaviour {

	public static int points;
	public static int bricks;
	public int bricksInternal;
	public Text scoreText; 
	public static int level=2;

	// Use this for initialization
	void Start () {
		points = 0;
	}
	
	// Update is called once per frame
	void Update () {
		bricksInternal = bricks;
		scoreText.text = "SCORE: " + points;
		
		if(bricksInternal <= 0){
			Ball.hasStarted = 0;
			//level++;
			Application.LoadLevel(++level);
		}
	}
}
