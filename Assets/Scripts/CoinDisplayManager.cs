using UnityEngine;
using System.Collections;

public class CoinDisplayManager : MonoBehaviour {

	public int playerCoins = 0000;

	public Sprite zero;
	public Sprite one;
	public Sprite two;
	public Sprite three;
	public Sprite four;
	public Sprite five;
	public Sprite six;
	public Sprite seven;
	public Sprite eight;
	public Sprite nine;

	public GameObject coinThousands;
	public GameObject coinHundreds;
	public GameObject coinTens;
	public GameObject coinOnes;

	// Use this for initialization
	void Start () {
		coinThousands.GetComponent<SpriteRenderer> ().sprite = zero;
		coinHundreds.GetComponent<SpriteRenderer> ().sprite = zero;
		coinTens.GetComponent<SpriteRenderer> ().sprite = zero;
		coinOnes.GetComponent<SpriteRenderer> ().sprite = zero;
	}
	
	// Update is called once per frame
	void Update () {
		var ones = playerCoins % 10;
		var tens = (playerCoins % 100 - ones) / 10;
		var hundreds = (playerCoins % 1000 - tens - ones) / 100;
		var thousands = (playerCoins % 10000 - hundreds - tens - ones) / 1000;

//		Debug.Log (thousands + " " + hundreds + " " + tens + " " + ones);

		// This is super shitty but I'm out of time to make it nice and elegant

		if (ones == 0) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = zero;
		} else if (ones == 1) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = one;
		} else if (ones == 2) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = two;
		} else if (ones == 3) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = three;
		} else if (ones == 4) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = four;
		} else if (ones == 5) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = five;
		} else if (ones == 6) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = six;
		} else if (ones == 7) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = seven;
		} else if (ones == 8) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = eight;
		} else if (ones == 9) {
			coinOnes.GetComponent<SpriteRenderer> ().sprite = nine;
		}

		if (tens == 0) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = zero;
		} else if (tens == 1) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = one;
		} else if (tens == 2) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = two;
		} else if (tens == 3) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = three;
		} else if (tens == 4) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = four;
		} else if (tens == 5) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = five;
		} else if (tens == 6) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = six;
		} else if (tens == 7) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = seven;
		} else if (tens == 8) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = eight;
		} else if (tens == 9) {
			coinTens.GetComponent<SpriteRenderer> ().sprite = nine;
		}

		if (hundreds == 0) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = zero;
		} else if (hundreds == 1) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = one;
		} else if (hundreds == 2) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = two;
		} else if (hundreds == 3) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = three;
		} else if (hundreds == 4) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = four;
		} else if (hundreds == 5) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = five;
		} else if (hundreds == 6) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = six;
		} else if (hundreds == 7) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = seven;
		} else if (hundreds == 8) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = eight;
		} else if (hundreds == 9) {
			coinHundreds.GetComponent<SpriteRenderer> ().sprite = nine;
		}

		if (thousands == 0) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = zero;
		} else if (thousands == 1) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = one;
		} else if (thousands == 2) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = two;
		} else if (thousands == 3) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = three;
		} else if (thousands == 4) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = four;
		} else if (thousands == 5) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = five;
		} else if (thousands == 6) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = six;
		} else if (thousands == 7) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = seven;
		} else if (thousands == 8) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = eight;
		} else if (thousands == 9) {
			coinThousands.GetComponent<SpriteRenderer> ().sprite = nine;
		}
	}
}
