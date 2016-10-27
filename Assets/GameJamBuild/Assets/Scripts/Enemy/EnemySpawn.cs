using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject instance;
	public Transform enemySpawn;
	public GameObject enemyPrefab;
	public GameObject destination;

	void Start(){


	}

	public void Spawn(int amount){

		Debug.Log ("Spawn called");

		for(int i = 0; i < amount; i++){
			
			instance = Instantiate (enemyPrefab, enemySpawn.position, Quaternion.Euler( 90, 0, 0)) as GameObject;//we are using this code to assign the variable of the nav mesh agent destination once the Gameobject actually spawns 
			//because you can't assign it to the prefab because once you place the object in the prefabs folder it loses all the variables you attached it to since those don't exist to that object yet...fuck
			instance.GetComponent<Enemy> ().destination = destination;//fuck this script... disgusting
			
		}
	}
}