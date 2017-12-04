using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonSpot : MonoBehaviour {

	public Card Summon = new Card();
	public Hand hand;

	public GameObject tempSummon;

	void OnMouseDown() {

		if (hand.draggingCard && Input.GetMouseButton (0) && hand.draggedCard.cardType == Card.CardType.Summon && Summon.cardName == "") {
			PlaySummon();
		}

		if( Input.GetMouseButton (1))
		{
			Debug.Log ("Deplaying card");
			DePlay ();
		}
	}		

	void PlaySummon()
	{
		Summon = hand.draggedCard;
		Debug.Log ("A Summon was placed");
		hand.hand[hand.prevIndex] = new Card ();
		hand.draggingCard = false;
		hand.draggedCard = null;
		/// tempSummon can be easily changed to Summon.cardModel
		Instantiate (tempSummon, transform.position, Quaternion.identity);
	}

	void DePlay()
	{
		Summon = new Card ();
		Destroy (tempSummon);
		Debug.Log ("Summon autodestroyed");
	}













}
