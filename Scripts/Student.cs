using UnityEngine;
using System.Collections;

public class Student : MonoBehaviour {
	
	public ParticleSystem captureParticle;
    private GameController gameController;
    private GameObject indicator;
    public GameObject locationIndicator;
	
	void Start(){
		PutIndicator();
	}
	
	void OnTriggerEnter(Collider c) {
		Destroy (this.gameObject);
		Vector3 temp = this.transform.position;
		GameObject temp2 = Instantiate (captureParticle, temp, this.transform.rotation) as GameObject;
		Destroy (temp2, 10);		
		GameController.IncrementScore();
		Destroy(indicator);
	}
	
	public void PutIndicator() {
		Vector3 pos = new Vector3 (transform.position.x, transform.position.y + 5f, transform.position.z);
		indicator = (GameObject)Instantiate (locationIndicator, pos, transform.rotation);
	}
}
