using UnityEngine;
using System.Collections;

public class VictoryCondition : MonoBehaviour {
	public ParticleSystem Explosion1;
	public ParticleSystem Explosion2;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	
	}
	void OnTriggerExit(){
		Application.LoadLevel (4);
	}
	void OnTriggerEnter(){
		Vector3 temp = this.transform.position;
		temp.y += 5;
		temp.z += 5;
		GameObject exploder1 = Instantiate (Explosion1, temp, this.transform.rotation) as GameObject;
		temp.x = temp.x + 10;
		temp.z -= 10;
		GameObject exploder2 = Instantiate (Explosion2, temp, this.transform.rotation)as GameObject;
		audio.Play();




	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
