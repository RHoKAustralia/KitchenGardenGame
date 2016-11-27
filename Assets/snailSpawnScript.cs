using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class snailSpawnScript : MonoBehaviour {

	public GameObject snail;

	public float spawnRepeatTime = 2.0f;
	public float randomXAmount = 10.0f;
	public float randomZAmount = 10.0f;
	Vector3 spawnPoint;

	void Start () {
		InvokeRepeating("addSnail", 0.0f, spawnRepeatTime);
	}

		
	void addSnail () {
		var xPosition = Random.Range(transform.position.x - randomXAmount, transform.position.x + randomXAmount);
		var zPosition = Random.Range(transform.position.z - randomZAmount, transform.position.z + randomZAmount);
		spawnPoint = new Vector3(xPosition,transform.position.y,zPosition);

		Instantiate(snail, spawnPoint, Quaternion.identity);
	}

	void Update () {

		

	}
}