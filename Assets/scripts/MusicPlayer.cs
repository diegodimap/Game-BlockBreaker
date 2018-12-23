using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

static MusicPlayer instance = null;

	// Use this for initialization
	
	void Awake(){
		print ("AWAKE ID="+GetInstanceID());
		if(instance != null){
			Destroy(gameObject);
			print ("DESTROY ID="+GetInstanceID());
		}else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	void Start () {
		print ("START ID="+GetInstanceID());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
