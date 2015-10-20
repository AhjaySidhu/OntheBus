using UnityEngine;
using System.Collections;

public class CameraSoundController : MonoBehaviour {
	private bool finish=false;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x>78&&!finish){
			finish=true;
			audio.Stop();
		}
	}
}
