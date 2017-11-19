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

	public bool drawingCard = false; // En el script controlador de turno, es true en la drawing fase; 

	private float w = Screen.width;
	private float h = Screen.height; 


	void Start()
	{
		for (int i = 0; i < slotsX; i++)
		{
			slots.Add(new Card());
			hand.Add(new Card());
		}
	}

	private void Update()
	{
		
		if (Input.GetButtonDown("i"))
		{
			showHand = !showHand;
			if (draggingCard) // Para el glitch de dragear y sacar el inventario
			{
				hand[prevIndex] = draggedCard;
				draggingCard = false;
				draggedCard = null;
			}
		}

		if (Input.GetMouseButtonDown (0)) // Este if usa la idea de fase de turno. (Soluciona el problema del doble click al tener que comprobar dos veces que está clickeado)
		{
			drawingCard = true;
		}

	}


	void OnGUI()
	{
		if (showHand) {
			DrawHand ();
		}

		if (draggingCard) {
			GUI.DrawTexture (new Rect (Event.current.mousePosition.x, Event.current.mousePosition.y, 50, 50), prueba);
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
	// FUNCIONES /////////////////////////////////////////////

	void DrawHand()
	{
		Event e = Event.current;
		int i = 0;
		GUI.Box(new Rect(w * 0.01f, h * 0.69f, w * 0.98f, h * 0.3f), ""); //UI BAK
		GUI.Box(new Rect(w * 0.75f, h * 0.71f, w * 0.12f, h * 0.26f), ""); // DeckSlot
		for (int x = 0; x < slotsX; x++)
		{
			float step = x * w * 0.13f;
			Rect slotRect = new Rect (step + w * 0.03f, h * 0.71f, w * 0.12f, h * 0.26f); // CardsSlot
			GUI.Box(new Rect(slotRect),"");
			slots[i] = hand[i];
			if (slots[i].cardName != null)
			{
				GUI.DrawTexture(slotRect, prueba);
				if (slotRect.Contains(e.mousePosition))
				{
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