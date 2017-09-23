using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

	public LayerMask movementMask;

	Camera cam;
	PlayerMotor motor;
	public GameObject clickPoint;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
		motor = GetComponent<PlayerMotor> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100, movementMask)) {
				Debug.Log (hit.point);
				GameObject clone =(GameObject)Instantiate(clickPoint, hit.point, Quaternion.identity);
				Destroy (clone, 1.5f);
				//Move our player to what we hit
				motor.MoveToPoint(hit.point);

				// stop focusing any objects

			}
		}

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = cam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100)) {

				//check if hit an interactable
				//if we did then set as focus

			}
		}
	}
}
