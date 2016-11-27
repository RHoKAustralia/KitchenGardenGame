using UnityEngine;
using System.Collections;

public class chickenScript : MonoBehaviour {
    public Transform target;
    public float speed;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
    void Update() {
//		Vector3 dir = new Vector3(0,0,0);
    	
		//transform.rotation = Quaternion.LookRotation(dir);
        //float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
		transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.time/100);
    }
}

