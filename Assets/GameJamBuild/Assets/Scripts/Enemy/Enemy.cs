﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int initialHealth = 20;//states the initial health of the enemy
	public GameObject destination;//identifies the nav mesh's destination
	public GameObject prefab;//enemy prefab
	NavMeshAgent agent;//references the navMeshAgent
	public int currentHealth;//updates the health of the enemy everytime take damage is called 

	void Start () {

		agent = GetComponent<NavMeshAgent> ();
		currentHealth = initialHealth;
		//prefab = GetComponent<EnemySpawn> ().instance;

	}

	void Update () 
	{

		agent.SetDestination (destination.transform.position);

	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		Debug.Log ("Current Health = " + currentHealth);

		if (currentHealth <= 0) {

			Destroy(gameObject);
		}
	}
}//livfuckingkicksalltheass