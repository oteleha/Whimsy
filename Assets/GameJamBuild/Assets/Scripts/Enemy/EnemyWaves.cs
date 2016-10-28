using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnemyWaves : MonoBehaviour {

	public Button play;
	public Image playImage;
	public float timeLeft = 50.0f;
	public Text timer;
	public Transform spawnPoint;
	public GameObject gridTiles;
	public int waveNumber;
	public Text waveText;

	public GameObject instance;
	public Transform enemySpawn;
	public GameObject enemyPrefab;
	public GameObject destination;

	public EnemyWaves enemyWaves;

	// Use this for initialization
	void Start () {

		//enemySpawn = GetComponent<EnemySpawn> ();
		playImage = play.GetComponentInChildren<Image> ();
		gridTiles.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {

//		timeLeft -= Time.deltaTime;
//		timer.text = "Timer:" + Mathf.RoundToInt (timeLeft);//#Livisabeautifulbutterfly
		//#fuckUnity
		//#damnStraight
		//LivperformsOralWell YESSSSSS
	}

	public void Spawn(int amount){

		Debug.Log ("Spawn called");

		for(int i = 0; i < amount; i++){

			instance = Instantiate (enemyPrefab, enemySpawn.position, Quaternion.Euler( 90, 0, 0)) as GameObject;//we are using this code to assign the variable of the nav mesh agent destination once the Gameobject actually spawns 
			//because you can't assign it to the prefab because once you place the object in the prefabs folder it loses all the variables you attached it to since those don't exist to that object yet...fuck
			instance.GetComponent<Enemy> ().destination = destination;//fuck this script... disgusting

		}
	}

//	void NextWave(){
//
//		if (!instance.activeInHierarchy) {
//
//			Invoke ("Spawn", 5f);
//
//		}
//
//	}

	public void TimerEnd(){
			
//		timeLeft = 0;
		gridTiles.SetActive (false);
		playImage.enabled = false;
		Spawn (5);
		waveNumber = 1;

	}
	public void OnClick(){
		
		TimerEnd ();
	}
//
//	public void SetTimerText(){
//
//
//		timer.text = "Timer:" + timeLeft.ToString();
//
//	}

	public void SetWaveText(){

		//waveText.text = waveNumber.ToString + "/4" ();

	}
}