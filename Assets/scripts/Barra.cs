using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Barra : MonoBehaviour {

	
	public float timeLeft = 600f;
	
	public Text mostradorTempo;
	
	public GameObject crackSound;
	
	private Ball ball;
	
	public bool isAutoTest = false;
	

	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		float x = (Input.mousePosition.x / Screen.width) * 16;
		//print ("X: " + x);
		
		if(x > 1 && x < 14.9){
			//if(Application.platform == RuntimePlatform.WindowsPlayer){
				transform.position = new Vector3(x, this.transform.position.y, this.transform.position.z);
			//}
			
			//auto test
			if(isAutoTest){
				float xball = ball.transform.position.x;
				this.transform.position = new Vector3(xball, this.transform.position.y, this.transform.position.z);
			}
			
			/*if(Application.platform == RuntimePlatform.Android){
				Screen.sleepTimeout = SleepTimeout.NeverSleep;
				float xa = Input.acceleration.x;
				float xb = (float) (xa*8 + 8);
				Vector3 v2 = new Vector3(xb, this.transform.position.y, this.transform.position.z);
				
				transform.position = v2;
			}*/
			
		} 
		 
		
		//time
		timeLeft -= Time.deltaTime;
		mostradorTempo.text = "TEMPO: " + timeLeft;
		if(timeLeft <=0){
			Application.LoadLevel("lose");
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		this.GetComponent<AudioSource>().Play();
	}
	
	public void tocarSom(){ 
		crackSound.GetComponent<AudioSource>().Play();
	}
}
