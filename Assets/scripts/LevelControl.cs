using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour {

	public void startGame(){
		SCORE.level = 2;
		Application.LoadLevel(2);
	}
	public void playAgain(){
		Application.LoadLevel(0);
	}
	public void winGame(){	
		Application.LoadLevel("win");
	}
	public void loseGame(){	
		Application.LoadLevel("lose");
	}
	public void quitGame(){	
		Application.Quit();
	}
	
	void Update(){
		
	}
}
