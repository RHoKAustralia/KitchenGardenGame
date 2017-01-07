using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CropHandler : MonoBehaviour {

	float startTime;
	public float growthTime = 10;
	private Slider growthSlider;
	private Slider healthSlider;
	// Use this for initialization
	void OnEnable () {
		startTime = Time.time;
		growthSlider = transform.Find("Canvas/GrowthSlider").GetComponent<Slider>();
		growthSlider.value = 0;
		healthSlider = transform.Find("Canvas/HealthSlider").GetComponent<Slider>();
		healthSlider.value = 100;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Time: " + growthTime + " " + startTime + " " + Time.time);
		float completionPercent = ((Time.time - startTime) / growthTime) * 100f;
		if(growthSlider && completionPercent < 100) {
			growthSlider.value = completionPercent;
		}
		if(completionPercent >= 100) {
			gameObject.SetActive(false);
		}
		if(healthSlider.value <= 0) {
			Destroy(gameObject);
		}
	}
		
	void OnTriggerStay(Collider col) {
		Debug.Log("Collision");
		healthSlider.value = healthSlider.value - 1;
//		foreach(ContactPoint contact in collision.contacts) {
//			Debug.DrawRay(contact.point, contact.normal, Color.white);
//		}
	}
}
