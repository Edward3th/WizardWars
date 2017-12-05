using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck {

	public List<Card> deck = new List<Card>();
	public int deckID;
	public string deckName;

	public Deck(List<Card> _deck,int _deckID,string _deckName)
	{
		deck = _deck;
		deckID = _deckID;
		deckName = _deckName;
	}
}
