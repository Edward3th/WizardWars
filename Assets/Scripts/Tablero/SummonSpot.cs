using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonSpot : MonoBehaviour {

	public Card Summon = new Card();
	public Hand hand;

	public GameObject tempSummon;

	void OnMouseDown() {

		// E3: Just check everything
		if (hand.draggingCard && Input.GetMouseButton (0) && hand.draggedCard.cardType == Card.CardType.Summon && Summon.cardName == "") {
			PlaySummon();
		}
			
	}		

	void PlaySummon()
	{
		Summon = hand.draggedCard;
		Debug.Log ("A Summon was placed");

		//E3: these lines are for freeing the space the card played used in hand script.
		hand.hand[hand.prevIndex] = new Card ();
		hand.draggingCard = false;
		hand.draggedCard = null;

		/// tempSummon can be easily changed to Summon.cardModel
		Instantiate (tempSummon, transform.position, Quaternion.identity);
	}













}
