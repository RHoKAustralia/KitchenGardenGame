using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CropHandler : MonoBehaviour {

	float startTime;
	private float growthTime = 10;
	private Slider growthSlider;
	// Use this for initialization
	void OnEnable () {
		startTime = Time.time;
		growthSlider = transform.Find("Canvas/GrowthSlider").GetComponent<Slider>();
		growthSlider.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Time: " + growthTime + " " + startTime + " " + Time.time);
		float completionPercent = ((Time.time - startTime) / growthTime) * 100f;
		if(growthSlider && completionPercent < 100) {
			growthSlider.value = completionPercent;
		}
		if(completionPercent >= 100) {
			gameObject.SetActive(false);
		}
	}
}
