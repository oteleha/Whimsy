using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnemyWaves : MonoBehaviour {

	public Button play;
	public Text playText;
	public float timeLeft = 50.0f;
	public Text timer;
	public Transform spawnPoint;
	public GameObject gridTiles;
	//private EnemySpawn enemySpawn;

	// Use this for initialization
	void Start () {

		//enemySpawn = GetComponent<EnemySpawn> ();
		playText = play.GetComponentInChildren<Text> ();
		gridTiles.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {

		timeLeft -= Time.deltaTime;
		timer.text = "Timer:" + Mathf.RoundToInt (timeLeft);//#Livisabeautifulbutterfly
		//#fuckUnity
		//#damnStraight
		//LivperformsOralWell YESSSSSS

			//timer stays at 0 and stays there and doesn't call TimerEnd(); hmm... I can't use Update to call the function either cause if I did as long as the if statement
			//remains true then it will constantly be spawning 5 enemies 
//			playText.enabled = false;
//			timer.enabled = false;
//			gridTiles.SetActive (false);
			//spawnPoint.GetComponent<EnemySpawn>().Spawn (1);
	}

	public void TimerEnd(){
			
			timeLeft = 0;
			gridTiles.SetActive (false);
			playText.enabled = false;
			timer.enabled = false;
			spawnPoint.GetComponent<EnemySpawn> ().Spawn (5);

	}
	public void OnClick(){
		
		TimerEnd ();
	}

	public void SetTimerText(){


		timer.text = "Timer:" + timeLeft.ToString();

	}
}
