using UnityEngine;
using System.Collections;
using TouchScript;

public class FieldContextHandler : MonoBehaviour {

	private void OnEnable()
	{
		if (TouchManager.Instance != null)
		{
			TouchManager.Instance.TouchesBegan += touchesBeganHandler;
		}
	}

	private void OnDisable()
	{
		if (TouchManager.Instance != null)
		{
			TouchManager.Instance.TouchesBegan -= touchesBeganHandler;
		}
	}

//	public float speed = 0.1F;
//	// Update is called once per frame
//	void Update () {
//		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
//			// Get movement of the finger since last frame
//			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
//			// Move object across XY plane
//			transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
//		}
//	}

	private void touchesBeganHandler(object sender, TouchEventArgs e)
	{
		foreach (var point in e.Touches)
		{
			Debug.Log(point.Tags + " touched down at " + point.Position);
		}
	}
}
