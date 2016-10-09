using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float movementSpeedMultiplier = 0.01f;
	private bool playerIsStationary;
	private string playerFacingDirection = "down";
	private bool playerIsMoving;

	// Use this for initialization
	void Start () {
		playerIsStationary = true;
		playerIsMoving = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!Input.GetKey ("down") && !Input.GetKey ("up") && !Input.GetKey ("left") && !Input.GetKey ("right")) {
			playerIsStationary = true;
		}

		if (Input.GetKey("down")) {
			transform.Translate(new Vector3 (0, -1, 0) * movementSpeedMultiplier);
			if (playerIsStationary) {
				SetPlayerDirection ("down");
			}
		}
		if (Input.GetKey ("up")) {
			transform.Translate (new Vector3 (0, 1, 0) * movementSpeedMultiplier);
			if (playerIsStationary) {
				SetPlayerDirection ("up");
			}
		}
		if (Input.GetKey ("left")) {
			transform.Translate (new Vector3 (-1, 0, 0) * movementSpeedMultiplier);
			if (playerIsStationary) {
				SetPlayerDirection ("left");
			}
		}
		if (Input.GetKey ("right")) {
			transform.Translate (new Vector3 (1, 0, 0) * movementSpeedMultiplier);
			if (playerIsStationary) {
				SetPlayerDirection ("right");
			}
		}

		if (playerIsMoving) {
			//play animation based on direction
		} else if (!playerIsMoving) {
			//set sprite to stationary
		}
	}

	void SetPlayerDirection(string dir) {
		playerIsStationary = false;

		playerFacingDirection = dir;
	}
}
