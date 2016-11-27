using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;
using System;

public class snailScript : MonoBehaviour {
    public Transform target;
    private float speed = 0.1f;
	private bool tapped = false;

	private GameObject plant;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
    void Update ()
	{	if(tapped) {
			gameObject.SetActive(false);
		} else {
			if(plant == null || plant.activeInHierarchy == false) {
				GameObject[] plants = GameObject.FindGameObjectsWithTag("Plant");
				if(plants.Length > 0) {
					plant = plants[UnityEngine.Random.Range(0, plants.Length)];
				}
			}
			if(plant) {
				transform.position = Vector3.Lerp(transform.position, plant.transform.position, Time.deltaTime * speed);
			}
		}
    }

	private void OnEnable()
	{
		GetComponent<TapGesture>().Tapped += tapHandler;
	}

	private void OnDisable()
	{
		GetComponent<TapGesture>().Tapped -= tapHandler;
	}

	private void tapHandler(object sender, EventArgs e)
	{
		gameObject.SetActive(false);
		//		var cornFieldTransform = transform.Find("Corn Field");
		//		if(canvas.activeInHierarchy == false) {
		//			
		//		}
		//		if(cornFieldTransform != null) {
		//			canvas.SetActive(false);
		//		}
	}
}

