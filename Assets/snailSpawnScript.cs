using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class snailSpawnScript : MonoBehaviour {

public GameObject snail;
//public GameObject inspection : GameObject;

public float spawnTime = 1.0f;
Vector3 spawnPoint;

void Start () {

	InvokeRepeating("addSnail", 0.0f, 0.4f);
	Debug.Log("hammmmm");

}

	
void addSnail () {

Debug.Log("fefsdf");
//var rd = GetComponent(Renderer);
//	var x1 = transform.position.x - rd.bounds.size.x/2;
//	var x2 = transform.position.x + rd.bounds.size.x/2;

	spawnPoint = new Vector3(transform.position.x,transform.position.y,transform.position.z);

	Instantiate(snail, spawnPoint, Quaternion.identity);
}

/*function addInspection() {
var rd = GetComponent(Renderer);
	//var x1 = transform.position.x - rd.bounds.size.x/2;
	//var x2 = transform.position.x + rd.bounds.size.x/2;


	var spawnPoint2 = Vector2(Random.Range(-4,4), Random.Range(-4, 4));
	Instantiate(inspection, spawnPoint2, Quaternion.identity);

}*/

void Update () {

	

}
}