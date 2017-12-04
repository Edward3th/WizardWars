using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeckDatabase : MonoBehaviour {

    public List<Card> Deckdatabase = new List<Card>();
	//// Aqui añado cartas en la interfaz de creador de Deck, aparece en la instancia del juego para agregar estas cartas al deck
    private void Start()
    {
		Deckdatabase.Add(new Card("Torre Básica", 0, "Una torre con ninguna peculiaridad", Card.CardType.Castle));
		Deckdatabase.Add(new Card("Torre Básica", 0, "Una torre con ninguna peculiaridad", Card.CardType.Castle));
		Deckdatabase.Add(new Card("Torre Básica", 0, "Una torre con ninguna peculiaridad", Card.CardType.Castle));
		Deckdatabase.Add(new Card("Torre OP", 1, "Una torre bastante OP", Card.CardType.Castle));
		Deckdatabase.Add(new Card("Torre OP", 1, "Una torre bastante OP", Card.CardType.Castle));
		Deckdatabase.Add(new Card("Torre OP", 1, "Una torre bastante OP", Card.CardType.Castle));
		Deckdatabase.Add(new Card("Golem de Obsidiana", 2, "Muy duro", Card.CardType.Summon));
		Deckdatabase.Add(new Card("Golem de Obsidiana", 2, "Muy duro", Card.CardType.Summon));
		Deckdatabase.Add(new Card("Arquero", 3, "Utiliza 1 Energía menos por ataque", Card.CardType.Summon));
		Deckdatabase.Add(new Card("Arquero", 3, "Utiliza 1 Energía menos por ataque", Card.CardType.Summon));
		Deckdatabase.Add(new Card("Manzana de Oro", 4, "Recupera en su totalidad la energía de una Invocación", Card.CardType.Reliq));
    }
}
