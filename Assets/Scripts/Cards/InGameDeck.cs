using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InGameDeck : MonoBehaviour {

	public List<Card> ingameDeck = new List<Card> (); //DECK for hand building
	public DeckDatabase database; // Brings the deck database from deck building
	public bool shuffle = true;

	void Start()
	{
		GetDeckFromData ();
		ShuffleDeck();
	}

	void Update()
	{
		if (shuffle && Input.GetMouseButton (1)) {
			ShuffleDeck ();
			Debug.Log ("Shuffling deck");
			shuffle = false;
		}

	}

	/// METHODS

	void GetDeckFromData()
	{
		for (int i = 0; i < database.Deckdatabase.Count; i++)
		{
			ingameDeck.Add (new Card ());
			ingameDeck[i] = database.Deckdatabase [i];

		}
	}



	void ShuffleDeck()
	{
		List<Card> temp = new List<Card>();
		temp.Add (new Card ());
		for (int i = 0; i < ingameDeck.Count; i++) 
		{
			temp[0] = ingameDeck [i];
			int randomIndex = Random.Range (i, ingameDeck.Count);
			ingameDeck[i] = ingameDeck [randomIndex];
			ingameDeck [randomIndex] = temp [0];
		}
		shuffle = false;
	}
}