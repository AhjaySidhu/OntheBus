using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
	AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		audio.time=127;
		audio.Play ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
