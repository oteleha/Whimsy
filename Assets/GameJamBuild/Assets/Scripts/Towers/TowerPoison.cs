using UnityEngine;
using System.Collections;

public class TowerPoison : MonoBehaviour {

	public Enemy enemy;
//	float attackTimer = 0.0f;
	public GameObject[] towerTypes;
	public int mushIndex;
	public ParticleSystem particle;
	public GameObject temp;
	public WaterUpgrade waterUpgrade;
	public MouseController mouseController;
	public GameObject tile;
	public GameObject gameManager;

	// Use this for initialization
	void Start () {
	
		//enemy = GetComponent<Enemy> ();
		particle = gameObject.GetComponent<ParticleSystem> ();
		//particle.Stop ();
		waterUpgrade = tile.GetComponent<WaterUpgrade>();
		mouseController = gameManager.GetComponent<MouseController> ();
	}
	
	// Update is called once per frame
	void Update () {

		tile = waterUpgrade.tile;

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
