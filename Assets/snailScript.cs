using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class snailScript : MonoBehaviour {
    public Transform target;
    public float speed;
    public Transform field1;
	public Transform field2;
	public Transform field3;
	public Transform field4;
	public Transform field5;
	public Transform field6;
	public Transform field7;
	public Transform field8;
	public Transform field9;
	int randNum;
	//GameObject[] fields = new Transform{field1,field2,field3,field4,field5,field6,field7,field8,field9};


	public List<Transform> fields;
	// Use this for initialization
	void Start () {

		Debug.Log("snail generated");

		randNum = Random.Range (0,9);
		fields.Add(field1);
		fields.Add(field2);
		fields.Add(field3);
		fields.Add(field4);
		fields.Add(field5);
		fields.Add(field6);
		fields.Add(field7);
		fields.Add(field8);
		fields.Add(field9);

		//fields.add(field1);
		//fields.add(field2);

		//Transform chosenField = fields[randNum];
		/*switch (randNum) {
			case 1: 
			field1;
			case 2: 
			field2;
			case 3: 
			field3;
			case 4: 
			field4;
			case 5: 
			field5;
			case 6: 
			field6;
			case 7: 
			field7;
			case 8: 
			field8;
			case 9: 
			field9;



		}*/

		Debug.Log(fields[0]);


    	//Debug.Log(target.FindChild("Field1"));
	//	Vector3 dir = new Vector3(0,0,0);
    	
		//transform.rotation = Quaternion.LookRotation(dir);
       // float step = speed * Time.deltaTime;


        //Transform chosenField = GetComponent("field1"+"1");
		//(string)this.GetType().GetField("field"+randNum).GetValue(this);

        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
	}

	// Update is called once per frame
    void Update ()
	{

		transform.position = Vector3.Lerp(transform.position, fields[randNum].transform.position, Time.time/100);
		
    }
}

