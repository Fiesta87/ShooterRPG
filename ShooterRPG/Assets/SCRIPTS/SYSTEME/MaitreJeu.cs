using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaitreJeu : MonoBehaviour {

	private float initialFixedDeltaTime;

	void Awake () {
		this.initialFixedDeltaTime = Time.fixedDeltaTime;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause () {
		Debug.Log("pause");
		Time.timeScale = 0.0f;
		Time.fixedDeltaTime = 0.0f;
	}

	public void Resume () {
		Debug.Log("resume");
		Time.timeScale = 1.0f;
		Time.fixedDeltaTime = this.initialFixedDeltaTime;
	}

	public void SetTimeSpeed (float speed) {
		Time.timeScale = speed;
		Time.fixedDeltaTime = speed * this.initialFixedDeltaTime;
	}
}
