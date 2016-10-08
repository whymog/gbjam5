using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int playerHealth = 6;

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth == 6) {
			heart3.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
			heart2.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
			heart1.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
		} else if (playerHealth == 5) {
			heart3.GetComponent<HeartIconToShow> ().thisHeartHealth = 1;
			heart2.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
			heart1.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
		} else if (playerHealth == 4) {
			heart3.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart2.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
			heart1.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
		} else if (playerHealth == 3) {
			heart3.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart2.GetComponent<HeartIconToShow> ().thisHeartHealth = 1;
			heart1.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
		} else if (playerHealth == 2) {
			heart3.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart2.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart1.GetComponent<HeartIconToShow> ().thisHeartHealth = 2;
		} else if (playerHealth == 1) {
			heart3.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart2.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart1.GetComponent<HeartIconToShow> ().thisHeartHealth = 1;
		} else if (playerHealth == 0) {
			heart3.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart2.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
			heart1.GetComponent<HeartIconToShow> ().thisHeartHealth = 0;
		}
	}
}
