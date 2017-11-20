using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonSpot : MonoBehaviour {

	public Card Summon = new Card();
	public Hand hand;


	void OnMouseDown() {

		if (hand.draggingCard && Input.GetMouseButton (0) && hand.draggedCard.cardType == Card.CardType.Summon ) {
			Summon = hand.draggedCard;
			Debug.Log ("A Summon was placed");
			hand.hand[hand.prevIndex] = new Card ();
			hand.draggingCard = false;
			hand.draggedCard = null;
		}
	}
}
