using UnityEngine;
using System.Collections;

public class DestroyFence : MonoBehaviour {
	public ParticleSystem glow1;

	// Use this for initialization
	void Start () {
	
	}

	public void BlowUp(){
		Vector3 temp = this.transform.position;
		int i = 0;
		do {
			temp.x = temp.x - i;
			GameObject temp2 = Instantiate (glow1, temp, this.transform.rotation) as GameObject;
			i += 3;
		} while(i<=6);
		Destroy (this.gameObject);


	}
	

}
