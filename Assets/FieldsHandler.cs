using UnityEngine;
using System.Collections;

public class FieldsHandler : MonoBehaviour {

	public GameObject fieldPrefab;
	public int rows;
	public int columns;
	private int size = 4;
	// Use this for initialization
	void Start () {
		for(var z = 0; z < rows; z++) {
			for(var x = 0; x < columns; x++) {
				GameObject cornObject = Instantiate(fieldPrefab, new Vector3(transform.position.x,transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
				cornObject.transform.parent = gameObject.transform;
				cornObject.transform.localPosition = new Vector3(size * x, 0, size * z);
			}
		}
	}
}
