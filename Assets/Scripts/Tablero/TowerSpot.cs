using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpot : MonoBehaviour {

	public Card Tower = new Card();
	public Hand hand;


	void OnMouseDown() {

		if (hand.draggingCard && Input.GetMouseButton (0) && hand.draggedCard.cardType == Card.CardType.Tower) {
			Tower = hand.draggedCard;
			Debug.Log ("A tower was placed");
			hand.hand[hand.prevIndex] = new Card ();
			hand.draggingCard = false;
			hand.draggedCard = null;
		}
	}
}
