using UnityEngine;
using System.Collections;

public class TowerPoison : MonoBehaviour {

	public Enemy enemy;
//	float attackTimer = 0.0f;
	public GameObject[] towerTypes;
	public int mushIndex;
	public ParticleSystem particle;
	public GameObject temp;


	// Use this for initialization
	void Start () {
	
		//enemy = GetComponent<Enemy> ();
		particle = gameObject.GetComponent<ParticleSystem> ();
		//particle.Stop ();
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == ("Enemy")){// && attackTimer <= 0f){

			enemy = other.GetComponent<Enemy> ();
			Debug.Log ("hit collider");

			enemy.TakeDamage (10);
			//attackTimer = 0f;
			particle.Play ();

		}
	}

	void OnTriggerExit(){

		particle.Stop ();

	}
}
