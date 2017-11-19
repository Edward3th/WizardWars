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
		totalCards.Add(new Card("Torre Básica",       0, "Una torre con ninguna peculiaridad",  Card.CardType.Castle ));
		totalCards.Add(new Card("Torre de Obsidiana", 1, "Una torre bastante OP",               Card.CardType.Castle));
		totalCards.Add(new Card("Golem de Obsidiana", 2, "Muy duro",                            Card.CardType.Summon));
		totalCards.Add(new Card("Arquero",            3, "Utiliza 1 Energía menos por ataque",  Card.CardType.Summon));
		totalCards.Add(new Card("Manzana de Oro",     4, "Recupera en su totalidad la energía de una Invocación", Card.CardType.Reliq));
    	
	}

}
