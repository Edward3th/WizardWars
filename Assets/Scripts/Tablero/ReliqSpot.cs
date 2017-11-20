using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReliqSpot : MonoBehaviour {

	public Card Reliq = new Card();
	public Hand hand;


	void OnMouseDown() {

		if (hand.draggingCard && Input.GetMouseButton (0) && hand.draggedCard.cardType == Card.CardType.Reliq) {
			Reliq = hand.draggedCard;
			Debug.Log ("A Reliq was placed");
			hand.hand[hand.prevIndex] = new Card ();
			hand.draggingCard = false;
			hand.draggedCard = null;
		}
	}
}
