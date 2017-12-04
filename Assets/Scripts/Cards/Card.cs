using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card {

    public string cardName;
    public int cardID;
    public string cardDesc;
    public CardType cardType;
	public Texture2D cardTexture;
	public GameObject cardModel;
	public int cardVitality;

    public enum CardType
    {
        Summon, Tower, Reliq, Wizard
    }


	/// Temporary constructor
	public Card(string name, int ID, string desc, CardType type)
    {
        cardName = name;
        cardID = ID;
        cardDesc = desc;
        cardType = type;	
    }

	/// Use this constructor when things are better
	public Card(string name, int ID, string desc, CardType type, Texture2D texture, GameObject model, int vitality)
	{
		cardName =     name;
		cardID =       ID;
		cardDesc =     desc;
		cardType =     type;
		cardTexture =  texture;
		cardModel =    model;
		cardVitality = vitality;

	}


	// Void Card
	public Card()
	{
		
	}

}
