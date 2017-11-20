using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour {

    public List<Card> totalCards = new List<Card>();
    // Aquí se almacenan TODAS las cartas del juego
	// Supongo que este Script con su respectivo GameObject no debería estar en la scene del tablero
	// Pero depende de la forma de cargar la información, quizás si
    private void Start()
    {
		totalCards.Add(new Card("Tower",       0, "A simple tower",  Card.CardType.Castle ));
		totalCards.Add(new Card("Obsidian Tower", 1, "A really strong tower",               Card.CardType.Castle));
		totalCards.Add(new Card("Obsidian Golem", 2, "A golem made of obsidian",                            Card.CardType.Summon));
		totalCards.Add(new Card("Archer",            3, "Uses 1 energy less for each attack",  Card.CardType.Summon));
		totalCards.Add (new Card ("Golden Apple", 4, "Restores the energy of a summoning", Card.CardType.Reliq));
	}

}
