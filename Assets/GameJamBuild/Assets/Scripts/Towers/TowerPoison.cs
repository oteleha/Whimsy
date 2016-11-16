using UnityEngine;
using System.Collections;

public class TowerPoison : MonoBehaviour {

	public Enemy enemy;
	public int mushIndex;
	public ParticleSystem particle;
	public WaterUpgrade waterUpgrade;
	public MouseController mouseController;
	public TowerSpawn towerSpawn;
	public GameObject tile;
	public GameObject gameManager;

	void Start () {
	
		particle = gameObject.GetComponent<ParticleSystem> ();
		waterUpgrade = tile.GetComponent<WaterUpgrade>();
		mouseController = gameManager.GetComponent<MouseController> ();
		towerSpawn = gameManager.GetComponent<TowerSpawn> ();
	}
	
	void Update () {


		tile = tile.GetComponent<WaterUpgrade>().tile;

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == ("Enemy")) {
			
			enemy = other.GetComponent<Enemy> ();
			Debug.Log ("hit collider");
			particle.Play ();
			enemy.TakeDamage (10);

//			if (tile.GetComponent<WaterUpgrade>().upgraded == true) {
//
//				Debug.Log ("Tower Upgraded!!!!");
//				enemy = other.GetComponent<Enemy> ();
//				enemy.TakeDamage (15);
//				particle.Play ();
//			}
		}
	}

	void OnTriggerExit(){

		particle.Stop ();

	}
}