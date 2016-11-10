using UnityEngine;
using System.Collections;

public class TowerPoison : MonoBehaviour {

	public Enemy enemy;
//	public GameObject[] towerTypes;
	public int mushIndex;
	public ParticleSystem particle;
	public GameObject temp;
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


			tile = towerSpawn.tile;



	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == ("Enemy")) {
			
			enemy = other.GetComponent<Enemy> ();
			Debug.Log ("hit collider");

			enemy.TakeDamage (10);
			particle.Play ();

			if (waterUpgrade.upgraded == true) {

				Debug.Log ("Tower Upgraded!!!!");
				enemy.TakeDamage (15);

			}
		}
	}

	void OnTriggerExit(){

		particle.Stop ();

	}
}