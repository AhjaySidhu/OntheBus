using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
	private static int score, highScore, prevScore,minutes, seconds, minutesMax, secondsMax;
	private float timer, sessionLimit;
	private string time;
	public DestroyFence fence1, fence2;
	public float timeLimit;
	public Text ScoreText;
	//public Text HighScoreText;
	public Text Timer;
	public GameObject Player1;
	public GameObject Player2;
	public GameObject Player3;
	public GameObject Player4;
	public GameObject Player5;
	
	
	// Use this for initialization
	void Start () {
		SpawnPlayer ();
		score = prevScore=0;
		highScore = 5;
		UpdateScore ();
		//timeLimit = 120;
		sessionLimit = timeLimit + Time.time;

		
	}
	
	// Update is called once per frame
	void Update () {
		timer = Time.time;
		minutes = Mathf.FloorToInt ((sessionLimit-timer) / 60f);
		seconds = Mathf.FloorToInt ((sessionLimit-timer) - minutes * 60);
		time = string.Format ("{0:0}:{1:00}", minutes,seconds);
		Timer.text ="Time Remaing: "+ time;
		if (score != prevScore) {
			prevScore++;
			UpdateScore();
		}
		if (sessionLimit-timer <= 0) {
						Application.LoadLevel(5);
		}
		if(score >= highScore) {
			//Application.LoadLevel(4);
			if(fence1!=null){
				fence1.BlowUp();
			}
			if(fence2!=null){
				fence2.BlowUp();
			}

		}
	}

	void UpdateScore(){

		ScoreText.text = "People Remaining: " + (highScore - score);

	}

	public static void IncrementScore() {

		score++;
		//UpdateScore ();

	}
	
	
	
	void SpawnPlayer() {
		var number = Random.Range (1, 5);
		switch (number) {
		case 1:
			Instantiate(Player1, new Vector3(39.61f,0,82.24f),Quaternion.identity);
			Instantiate(Player2, new Vector3(60.74f,0,41.96f),Quaternion.identity);
			Instantiate(Player3, new Vector3(12.2f,0,42.49f),Quaternion.identity);
			Instantiate(Player4, new Vector3(9.51f,0,121.76f),Quaternion.identity);
			Instantiate(Player5, new Vector3(40.36f,0,8.30f),Quaternion.identity);
			break;
		case 2:
			Instantiate(Player1, new Vector3(25.1f,0,85.78f),Quaternion.identity);
			Instantiate(Player2, new Vector3(44.44f,0,66.85f),Quaternion.identity);
			Instantiate(Player3, new Vector3(63.5f,0,56.4f),Quaternion.identity);
			Instantiate(Player4, new Vector3(35.16f,0,6.25f),Quaternion.identity);
			Instantiate(Player5, new Vector3(45f,0,112.8f),Quaternion.identity);
			break;
		case 3:
			Instantiate(Player1, new Vector3(49.03f,0,110f),Quaternion.identity);
			Instantiate(Player2, new Vector3(2.12f,0,84.1f),Quaternion.identity);
			Instantiate(Player3, new Vector3(68.23f,0,31.76f),Quaternion.identity);
			Instantiate(Player4, new Vector3(1.93f,0,20.73f),Quaternion.identity);
			Instantiate(Player5, new Vector3(48.57f,0,20.36f),Quaternion.identity);
			break;
		case 4:
			Instantiate(Player1, new Vector3(2.02f,0,38.39f),Quaternion.identity);
			Instantiate(Player2, new Vector3(68.62f,0,71.66f),Quaternion.identity);
			Instantiate(Player3, new Vector3(43.8f,0,1.87f),Quaternion.identity);
			Instantiate(Player4, new Vector3(41.18f,0,115.16f),Quaternion.identity);
			Instantiate(Player5, new Vector3(1.7f,0,121.7f),Quaternion.identity);
			break;
		case 5:
			Instantiate(Player1, new Vector3(68.4f,0,6.43f),Quaternion.identity);
			Instantiate(Player2, new Vector3(3.05f,0,122f),Quaternion.identity);
			Instantiate(Player3, new Vector3(8.49f,0,9.19f),Quaternion.identity);
			Instantiate(Player4, new Vector3(68.4f,0,126.2f),Quaternion.identity);
			Instantiate(Player5, new Vector3(42.28f,0,62.2f),Quaternion.identity);
			break;
		}
	}
}

