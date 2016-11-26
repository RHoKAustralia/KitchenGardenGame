using UnityEngine;
using System.Collections;
using TouchScript;

public class FieldContextHandler : MonoBehaviour {
//	public float speed = 0.1F;
//	// Update is called once per frame
	public GameObject cornPrefab;

	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
			// Get movement of the finger since last frame
			//Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			// Move object across XY plane
			//transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
			transform.Find("Canvas").gameObject.SetActive(true);
		}
	}

	public void OnClickCorn() {
		transform.Find("Canvas").gameObject.SetActive(false);
		GameObject cornObject = Instantiate(cornPrefab, new Vector3(transform.position.x,transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
		cornObject.transform.parent = gameObject.transform;
	}
}
