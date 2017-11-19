using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card {

    public string cardName;
    public int cardID;
    public string cardDesc;
    public Texture2D cardTexture;
	public GameObject cardModel;
    public CardType cardType;
	public int cardVitality;


    public enum CardType
    {
        Summon, Castle, Reliq, Wizard
    }

    // Summons and Castle
	public Card(string name, int ID, string desc, CardType type)
    {
        cardName = name;
        cardID = ID;
        cardDesc = desc;
        cardType = type;
		
    }

	// Void Card
	public Card()
	{
		
	}

}
