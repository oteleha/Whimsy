using UnityEngine;
using System.Collections;

public class TowerVenus : MonoBehaviour {

	public Collider enemyCol;//sets the enemyCol to be equal to the collider that is being used in the function OnTriggerEnter
	public Enemy enemy;//reference to the script Enemy

	public Animator animator;//reference to the animator on the gameobject

	public GameObject enemyPrefab;//reference to the reference of the enemy script
	public GameObject tower;//reference to the tower gameobject

	void Start () {

		animator = tower.GetComponent<Animator> ();
		//enemy = enemyPrefab.GetComponent<Enemy> ();

	}

	public void OnTriggerEnter(Collider other)
	{
		Debug.Log("Hit: " + other.transform.name);
		if (other.gameObject.tag == ("Enemy")){
			
			enemyCol = other;
			animator.SetBool ("isAttacking", true);
			//enemyPrefab.GetComponent<Enemy>().TakeDamage (15);
			other.gameObject.GetComponent<Enemy>().TakeDamage (15);
			Debug.Log ("taking damage");// #livisamazing

		}
	}

	void OnTriggerExit(Collider other){

		animator.SetBool ("isAttacking", false);

	}
}