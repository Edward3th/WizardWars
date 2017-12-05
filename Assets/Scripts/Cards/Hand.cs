using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

	private int slotsX = 5;

	public List<Card> hand = new List<Card>();
	public List<Card> slots = new List<Card>();
	private bool showHand = false;
	public InGameDeck deck;
	public Texture2D prueba;

	public bool draggingCard;
	public Card draggedCard;
	public int prevIndex;

	public bool drawingCard = false;  

	private float w = Screen.width;
	private float h = Screen.height;

	private bool showTooltip;
	private string tooltip;


	void Start()
	{
		//E3: This initialize the hand
		for (int i = 0; i < slotsX; i++)
		{
			slots.Add(new Card());
			hand.Add(new Card());
		}
	}

	private void Update()
	{

		//E3: This show the hand and deck interface
		if (Input.GetButtonDown("i"))
		{
			showHand = !showHand;
			//E3: This is needed because a glitch
			if (draggingCard) 
			{
				hand[prevIndex] = draggedCard;
				draggingCard = false;
				draggedCard = null;
			}
		}

		//E3: This is needed to draw a card plus the mouse position on OnGUI
		if (Input.GetMouseButtonDown (0)) 
		{
			drawingCard = true;
		}



	}


	void OnGUI()
	{

		tooltip = "";

		if (showHand) {
			DrawHand ();
		}


		if (showTooltip) {
		
			GUI.Box (new Rect (Event.current.mousePosition.x,Event.current.mousePosition.y-200,200,200), tooltip);
		}
			

		if (draggingCard) {
			showTooltip = false;
			GUI.DrawTexture (new Rect (Event.current.mousePosition.x, Event.current.mousePosition.y, 140, 200), prueba);
		}

		if (drawingCard) 
		{
			if (new Rect (w * 0.75f, h * 0.71f, w * 0.12f, h * 0.26f).Contains (Event.current.mousePosition) && Input.GetMouseButtonDown(0)) 
			{
				DrawCardFromDeck ();
				drawingCard = false;
			}
	
		}
	}


	// METHODS /////////////////////////////////////////////

	void DrawHand()
	{
		Event e = Event.current;
		int i = 0;
		GUI.Box(new Rect(w * 0.01f, h * 0.69f, w * 0.98f, h * 0.3f), ""); //UI BACKGROUND
		GUI.Box(new Rect(w * 0.75f, h * 0.71f, w * 0.12f, h * 0.26f), ""); // DeckSlot
		for (int x = 0; x < slotsX; x++)
		{
			float step = x * w * 0.13f;
			Rect slotRect = new Rect (step + w * 0.03f, h * 0.71f, w * 0.12f, h * 0.26f); // CardsSlots
			GUI.Box(new Rect(slotRect),"");
			slots[i] = hand[i];
			if (slots[i].cardName != null)
			{
				GUI.DrawTexture(slotRect, prueba); // here instead of "prueba" draggedCard.cardSprite
				if (slotRect.Contains(e.mousePosition))
				{
					CreateTooltip (slots [i]);
					showTooltip = true;

					if (e.button == 0 && e.type == EventType.mouseDrag && !draggingCard)
					{
						draggingCard = true;
						prevIndex = i;
						draggedCard = slots[i];
						hand[i] = new Card();
					}

					if (e.type == EventType.mouseUp && draggingCard)
					{
						hand[prevIndex] = hand[i];
						hand[i] = draggedCard;
						draggingCard = false;
						draggedCard = null;
					}

				}

				if (tooltip == "") {
					showTooltip = false;
				}
			}
			else // ESTE ELSE ES PARA CAMBIAR CON ESPACIOS VACIOS
			{
				if (slotRect.Contains(e.mousePosition))
				{
					if (e.type == EventType.mouseUp && draggingCard)
					{
						hand[prevIndex] = hand[i];
						hand[i] = draggedCard;
						draggingCard = false;
						draggedCard = null;
					}
				}
			}
			i++;
			}
		}

	string CreateTooltip(Card card)
	{
		tooltip = card.cardName + "\n\n\n" + card.cardDesc ;
		return tooltip;
	}

	void DrawCardFromDeck()
	{
		for (int i = 0; i < slotsX; i++)
		{
			if (hand [i].cardName == null && deck.ingameDeck[0].cardName != null) 
			{
				hand [i] = deck.ingameDeck[0];
				deck.ingameDeck.Remove (deck.ingameDeck [0]);
				break;

			}

		}
	}






}