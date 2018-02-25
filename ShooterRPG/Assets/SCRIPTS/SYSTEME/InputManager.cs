using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public float horizontal;
	public float vertical;
	public float mouseX;
	public float mouseY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.horizontal = Input.GetAxis("Horizontal");
		this.vertical = Input.GetAxis("Vertical");
		this.mouseX = Input.GetAxis("Mouse X");
		this.mouseY = Input.GetAxis("Mouse Y");


	}
}
