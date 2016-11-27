using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class snailScript : MonoBehaviour {
    public Transform target;
    public float speed;

	private GameObject field;
	// Use this for initialization
	void Start () {
		field = GameObject.Find("Field");
	}

	// Update is called once per frame
    void Update ()
	{
		if(field) {
			transform.position = Vector3.Lerp(transform.position, field.transform.position, Time.time / 100);
		}
    }
}

