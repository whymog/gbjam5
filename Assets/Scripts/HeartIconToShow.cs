using UnityEngine;
using System.Collections;

public class HeartIconToShow : MonoBehaviour {

	public int thisHeartHealth = 2;
	public int thisHeartPlace;

	public Sprite heartFull;
	public Sprite heartHalfFull;
	public Sprite heartEmpty;

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (thisHeartHealth == 2) {
			sr.sprite = heartFull;
		} else if (thisHeartHealth == 1) {
			sr.sprite = heartHalfFull;
		} else if (thisHeartHealth == 0) {
			sr.sprite = heartEmpty;
		}
	}
}
