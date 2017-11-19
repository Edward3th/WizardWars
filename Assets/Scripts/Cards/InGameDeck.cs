using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InGameDeck : MonoBehaviour {

	public List<Card> ingameDeck = new List<Card> (); //DECK para pasar a Hand
	public DeckDatabase database; // Trae el script que contiene el deck no modificable
	public bool shuffle = true;
	//Aquí se almacenan las cartas del deck in.game
	void Start()// Deck de Cartas. Las retiro al sacarla y pueden revolvers
	{
		GetDeckFromData ();
		ShuffleDeck();
	}

	void Update()
	{
		if (Input.GetMouseButton (1)) {
			shuffle = true;
		}
		if (shuffle) {
			ShuffleDeck ();
		}

	}

	/// Funciones

	void GetDeckFromData()
	{
		for (int i = 0; i < database.Deckdatabase.Count; i++)
		{
			ingameDeck.Add (new Card ());
			ingameDeck[i] = database.Deckdatabase [i];

		}
	}


	void ShuffleDeck() // Revuelve las cartas del deck
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