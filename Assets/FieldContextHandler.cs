using UnityEngine;
using System.Collections;
using TouchScript;
using TouchScript.Gestures;
using System;

public class FieldContextHandler : MonoBehaviour {
//	public float speed = 0.1F;
//	// Update is called once per frame
	public GameObject cornPrefab;

//	void Update () {
//		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
//			// Get movement of the finger since last frame
//			//Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
//			// Move object across XY plane
//			//transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
//			transform.Find("Canvas").gameObject.SetActive(true);
//		}
//
//		if(Input.GetMouseButtonDown(0))
//		{
////			Debug.Log("Pressed left click.");
////			transform.Find("Canvas").gameObject.SetActive(true);
//			RaycastHit hit; 
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
//			if ( Physics.Raycast(ray,out hit,100.0f)) {
//				Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object
//				Debug.DrawRay(hit.point, hit.normal, Color.green, 2, false);
//			}
//		}
//	}

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
		var canvas = transform.Find("Canvas").gameObject;
		canvas.SetActive(true);
//		var cornFieldTransform = transform.Find("Corn Field");
//		if(canvas.activeInHierarchy == false) {
//			
//		}
//		if(cornFieldTransform != null) {
//			canvas.SetActive(false);
//		}
	}


	public void OnClickCorn() {
		transform.Find("Canvas").gameObject.SetActive(false);
		GameObject cornObject = Instantiate(cornPrefab, new Vector3(transform.position.x,transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
		cornObject.transform.parent = gameObject.transform;
	}
}
