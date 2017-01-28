using UnityEngine;
using System.Collections;

public class TorchFlicker : MonoBehaviour {

	public Light flickerLight;
	public float timer;
	public float normTime;
	public float normIntensity;
	public float highIntensity;

	// Use this for initialization
	void Start () {
		StartCoroutine (FlickeringLight ());
	}

	IEnumerator FlickeringLight(){
		flickerLight.intensity = normIntensity;
		timer = Random.Range (normTime/2, normTime);
		yield return new WaitForSeconds (timer);
		flickerLight.intensity = highIntensity;
		timer = Random.Range (0.05f, 0.1f);
		yield return new WaitForSeconds (timer);
		if (Mathf.RoundToInt (Random.value) == 1) {
			flickerLight.intensity = 0;
		}
		timer = Random.Range (0.5f, 1.5f);
		yield return new WaitForSeconds (timer);
		StartCoroutine (FlickeringLight());
	}
}
