using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour {

    public List<Card> totalCards = new List<Card>();
    // Total card database
    private void Start()
    {
		totalCards.Add(new Card("Tower",          0,"",  Card.CardType.Tower));
		totalCards.Add(new Card("Obsidian Tower", 1,"",  Card.CardType.Tower));
		totalCards.Add(new Card("Archer Tower",   2,"",  Card.CardType.Tower));
		totalCards.Add(new Card("Cannon Tower",   3,"",  Card.CardType.Tower));
		totalCards.Add(new Card("Skyscraper",     4,"",  Card.CardType.Tower));
		totalCards.Add(new Card("Pyramid",        5,"",  Card.CardType.Tower));
		totalCards.Add(new Card("Old Ruins",      6,"",  Card.CardType.Tower));
		totalCards.Add(new Card("Goblins",        7,"",  Card.CardType.Summon));
		totalCards.Add(new Card("Stone Golem",    8,"",  Card.CardType.Summon));
		totalCards.Add(new Card("Obsidian Golem", 9,"",  Card.CardType.Summon));
		totalCards.Add(new Card("Archers",        10,"", Card.CardType.Summon));
		totalCards.Add(new Card("Executives",     11,"", Card.CardType.Summon));
		totalCards.Add(new Card("Wolves",         12,"", Card.CardType.Summon));
		totalCards.Add(new Card("Golden Apple",   13,"Restores the energy of a summoning", Card.CardType.Reliq));
		totalCards.Add(new Card("Golden Sword",   14,"Gives more energy to a summoning",   Card.CardType.Reliq));

	}

}
