using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Barra barra;
	
	private Vector3 barra2ballVector;
	
	public static int hasStarted = 0;
	
	public float velocidade = 5f;
	
	public float angulo = 2f;
	

	// Use this for initialization
	void Start () {
		hasStarted = 0;
		barra2ballVector = this.transform.position - barra.transform.position;
		//print("VECTOR: " + barra2ballVector);  
	}
	
	// Update is called once per frame
	void Update () {
		if(hasStarted==0)
		this.transform.position = barra.transform.position + barra2ballVector;
		
		if(Input.GetMouseButtonDown(0)){
			
			print ("CLICKED");
			if(hasStarted==0){
				this.rigidbody2D.velocity = new Vector2(angulo,velocidade);
			}
			hasStarted = 1;
		}
	}
	
	void OnCollisionEnter2D(Collision2D c){
		Vector2 aleatorio = new Vector2(Random.Range(0f, 0.2f),Random.Range(0f, 0.2f));
		//print (aleatorio);
		rigidbody2D.velocity += aleatorio;
	}
}
