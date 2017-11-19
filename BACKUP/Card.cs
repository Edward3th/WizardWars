using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card {

    public string cardName;
    public int cardID;
    public string cardDesc; // Habilidad???
    public Texture2D cardTexture;
    public CardType cardType;

    //public int Estructure; //Para Castle
    //public int Energy; //Summon
    // En caso de que necesite mas variables por CardType

    public enum CardType
    {
        Summon, Castle, Reliq, Wizard
    }

    // Para diferenciar las acartas podría usar otras formas de public Card que exijan esos argumentos
	public Card(string name, int ID, string desc, CardType type)
    {
        cardName = name;
        cardID = ID;
        cardDesc = desc;
        cardType = type;
		//cardTexture = texture;
    }
		

    public Card()
    {

    }


}
