using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Brick : MonoBehaviour {

	public int maxHits=0;
	public int hits;
	public Sprite tijolo1;
	public Sprite tijolo2;
	public Sprite tijolo3;
	public int timeLeft = 10;
	public AudioClip crack; 
	public GameObject smoke; 

	// Use this for initialization
	void Start () {
		hits = 0;
		SCORE.bricks++;
		//crack = (AudioClip) Resources.Load("sounds/crack");
		//smoke.transform.position = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(maxHits==2 && hits==1){
			GetComponent<SpriteRenderer>().sprite = tijolo2;
		}
		if(maxHits==3 && hits==1){
			GetComponent<SpriteRenderer>().sprite = tijolo2;
		}
		if(maxHits==3 && hits==2){
			GetComponent<SpriteRenderer>().sprite = tijolo3;
		}
	
		if(hits >= maxHits){
			tocarCrack();
			
			SCORE.points += 100*maxHits;
			SCORE.bricks--;
			
			//ultima coisa eh destruir
			Instantiate(smoke, this.transform.position, Quaternion.identity);
			gameObject.SetActive(false);
		}
		   
	}
	
	void tocarCrack(){
		AudioSource.PlayClipAtPoint(crack, transform.position, 0.25f);
	}
	 
	
	void OnCollisionEnter2D(Collision2D col){
		//bounce.Play();
		if(Ball.hasStarted == 1)
			this.GetComponent<AudioSource>().Play();
		
		hits++;
	}
}
