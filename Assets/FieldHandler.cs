using UnityEngine;
using System.Collections;

public class FieldHandler : MonoBehaviour {

	GameObject cornField;

	// Use this for initialization
	void Start () {
		cornField = gameObject.transform.Find("Corn Field").gameObject;
		cornField.SetActive(false);
	}

	void OnMouseDown() {
		if(cornField.activeInHierarchy) {
			cornField.SetActive(false);
		} else {
			cornField.SetActive(true);
		}
	}
}
