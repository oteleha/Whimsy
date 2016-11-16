using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnemyWaves : MonoBehaviour {

	public Button play;
	public Image playImage;
	public Text waveText;
	public Transform enemySpawn;

	public GameObject instance;
	public GameObject enemyPrefab;
	public GameObject destination;
	public GameObject tileHolder;
//	public SpriteRenderer[] tileRenderers;

//	public EnemyWaves enemyWaves;

	void Start () {

		playImage = play.GetComponentInChildren<Image> ();
//		gridTiles.SetActive (true);
		SpriteRenderer[] tileRenderers = tileHolder.GetComponentsInChildren<SpriteRenderer>();
		foreach (SpriteRenderer rend in tileRenderers) {

			rend.enabled = true;
		}
	}

	void Update () {

		//#Livisabeautifulbutterfly
		//#fuckUnity
		//#damnStraight
		//LivPerformsOralWell YESSSSSS
	}

	public void Spawn(int amount){

		Debug.Log ("Spawn called");

		for(int i = 0; i < amount; i++){

			instance = Instantiate (enemyPrefab, enemySpawn.position, Quaternion.Euler( 90, 0, 0)) as GameObject;//we are using this code to assign the variable of the nav mesh agent destination once the Gameobject actually spawns 
			//because you can't assign it to the prefab because once you place the object in the prefabs folder it loses all the variables you attached it to since those don't exist to that object yet...fuck
			instance.GetComponent<Enemy> ().destination = destination;//fuck this script... disgusting

		}
	}

	void NextWave(){

		if (!instance.activeInHierarchy) {

			Invoke ("Spawn", 5f);

		}

	}

	public void WaveStart(){
			
//		timeLeft = 0;
//		gridTiles.SetActive (false);
		SpriteRenderer[] tileRenderers = tileHolder.GetComponentsInChildren<SpriteRenderer>();
		foreach (SpriteRenderer rend in tileRenderers) {

			rend.enabled = false;
		}

		playImage.enabled = false;
		Spawn (1);
		SetWaveText (1);

	}

	public void OnClick(){
		
		WaveStart ();
	}

	public void SetWaveText(int waveNumber){

		waveText.text = waveNumber.ToString() + "/4";

	}
}