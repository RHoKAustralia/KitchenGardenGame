using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class snailScript : MonoBehaviour {
    public Transform target;
    private float speed = 0.1f;

	private GameObject plant;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
    void Update ()
	{	
		if(plant == null || plant.activeInHierarchy==false) {
			GameObject[] plants = GameObject.FindGameObjectsWithTag("Plant");
			if(plants.Length > 0) {
				plant = plants[Random.Range(0, plants.Length)];
			}
		}
		if(plant) {
			transform.position = Vector3.Lerp(transform.position, plant.transform.position, Time.deltaTime * speed);
		}
    }
}

