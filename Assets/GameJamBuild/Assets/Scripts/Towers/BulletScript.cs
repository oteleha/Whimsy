using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float speed;
	public int timer;
	public GameObject target;
	public GameObject tower;

	// Use this for initialization
	void Start () {
		speed = 10f;
		timer = 0;
	}

	//Constructor
	public void Set_Target(GameObject t){
		
		target = t;
	}

	//Destroyer Function
	public void Kill_Bullet(){
		
		Destroy (gameObject, 0f);

	}

	
	// Update is called once per frame
	void Update () {
		
		//Constantly move the projectile towards the target
		transform.position = Vector3.MoveTowards (transform.position, new Vector3(target.transform.position.x, 0.5f, target.transform.position.z), speed);

	}

	//When the projectile hits the target
	void OnTriggerEnter(Collider other){
		//Make sure the target is the original target
		if (other.gameObject == target) {

			target.GetComponent<Enemy> ().TakeDamage (5);

			Kill_Bullet ();

		}

		if (!target) {

			Kill_Bullet ();
		}
	}
}
