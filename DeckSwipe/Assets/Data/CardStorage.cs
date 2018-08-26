﻿using System.Collections.Generic;
using GoogleSheets;
using UnityEngine;

public class CardStorage {
	
	private List<CardModel> cards = new List<CardModel>();
	private GoogleSheetsImporter googleSheetsImporter = new GoogleSheetsImporter();
	
	public CardStorage(Sprite defaultSprite) {
		Populate(defaultSprite);
		googleSheetsImporter.FetchCardData();
	}
	
	public void Populate(Sprite defaultSprite) {
		CharacterModel leadExplorer = new CharacterModel("Lead explorer", defaultSprite);
		cards.AddRange(new List<CardModel> {
				new CardModel("This is a test card text that should appear on screen.",
						"Here goes",
						"There goes",
						new CharacterModel("Dr. Bartholomew Oobleck", defaultSprite), 
						new CardActionOutcome(-4, 4, -2, 2),
						new CardActionOutcome(2, 0, 4, -2)),
				new CardModel("And this is yet another card that you may encounter in the game. Are you having fun thus far?",
						"No",
						"Yes",
						new CharacterModel("Peter Port", defaultSprite),
						new CardActionOutcome(-1, -1, -1, -1),
						new CardActionOutcome(2, 2, 2, 2)),
				new CardModel("The hothouse is very cold. The crops are freezing up. What should we do?",
						"Turn on the heater in the hothouse",
						"Put the generator in overdrive",
						new CharacterModel("Oliver Rain", defaultSprite),
						new CardActionOutcome(1, 1, 0, -2),
						new CardActionOutcome(2, 2, -2, -4)),
				new CardModel("The scouts come across what looks to be a wrecked ship. Should they explore it?",
						"No",
						"Yes",
						leadExplorer,
						new CardActionOutcome(0, 0, 0, 0),
						new CardActionOutcome(0, 0, 0, 0)),
				new CardModel("The scouts find 2 steam cores and a shipment of wood on board the ship. A crew had been trying to survive in the wreck but everybody's dead now.",
						"",
						"",
						leadExplorer,
						new CardActionOutcome(3, 0, 2, 6),
						new CardActionOutcome(3, 0, 2, 6)),
				new CardModel("The guards bring a woman to you. She yells \"These swine have been pestering me day in day out! How much does it take to tell them to leave me alone?\".",
						"Reprimend the guards",
						"Leave it be",
						new CharacterModel("", defaultSprite),
						new CardActionOutcome(0, 1, 1, 0),
						new CardActionOutcome(0, 0, -1, 0)),
				new CardModel("An automaton got stuck in a hothouse. What do we do with it?",
						"Disable the automaton",
						"Disable the hothouse",
						new CharacterModel("Alice Woodrow", defaultSprite),
						new CardActionOutcome(-2, -2, 0, -2),
						new CardActionOutcome(+2, -4, 0, -2)),
		});
	}
	
	public CardModel Random() {
		return cards[UnityEngine.Random.Range(0, cards.Count)];
	}
	
}