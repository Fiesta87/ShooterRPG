using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurDeplacement : MonoBehaviour {

	private InputManager inputManager;
	private GameObject cam;
	private float angleX;
	private float angleY;

	void Awake () {
		this.inputManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<InputManager>();
		this.cam = GameObject.FindGameObjectWithTag("MainCamera");
		Vector3 v = this.cam.transform.rotation.eulerAngles;
		this.angleX = v.x;
		this.angleY = v.y;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		this.UpdateRegard();
		if(this.EstAuSol()){
			this.UpdatePosition();
		}
	}

	public bool EstAuSol () {
		return true;
	}

	private void UpdatePosition () {
		this.transform.position +=
			this.transform.forward * this.inputManager.vertical +
			this.transform.right * this.inputManager.horizontal;
	}

	private void UpdateRegard () {

		this.angleX = Mathf.Clamp(this.angleX - this.inputManager.mouseY, -85.0f, 85.0f);
		this.angleY += this.inputManager.mouseX;

		this.cam.transform.rotation = Quaternion.Euler(angleX, angleY, 0.0f);

		Vector3 v = this.cam.transform.forward;
		v.y = 0;

		this.transform.forward = v.normalized;
	}
}
