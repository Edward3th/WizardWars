using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeckDatabase : MonoBehaviour {

    public List<Card> Deckdatabase = new List<Card>();
	//// Aqui añado cartas en la interfaz de creador de Deck, aparece en la instancia del juego para agregar estas cartas al deck
    private void Start()
    {
		Deckdatabase.Add(new Card("Tower",       0, "A simple tower",  Card.CardType.Castle ));
		Deckdatabase.Add(new Card("Tower",       0, "A simple tower",  Card.CardType.Castle ));
		Deckdatabase.Add(new Card("Tower",       0, "A simple tower",  Card.CardType.Castle ));
		Deckdatabase.Add(new Card("Obsidian Tower", 1, "A really strong tower",               Card.CardType.Castle));
		Deckdatabase.Add(new Card("Obsidian Tower", 1, "A really strong tower",               Card.CardType.Castle));
		Deckdatabase.Add(new Card("Obsidian Golem", 2, "A golem made of obsidian",                            Card.CardType.Summon));
		Deckdatabase.Add(new Card("Archer",            3, "Uses 1 energy less for each attack",  Card.CardType.Summon));
		Deckdatabase.Add(new Card("Archer",            3, "Uses 1 energy less for each attack",  Card.CardType.Summon));
		Deckdatabase.Add(new Card("Archer",            3, "Uses 1 energy less for each attack",  Card.CardType.Summon));
		Deckdatabase.Add (new Card ("Golden Apple", 4, "Restores the energy of a summoning", Card.CardType.Reliq));
    }
}
