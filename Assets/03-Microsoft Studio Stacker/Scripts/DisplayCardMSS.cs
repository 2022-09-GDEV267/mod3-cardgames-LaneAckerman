using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayCardMSS : MonoBehaviour
{
    public List<CardMSS> DisplayCard = new List<CardMSS>();
    public int displayId;

    public int id;
    public string cardName;
    public int design;
    public int build;
    public int test;
    public int publish;
    public string genreColor;
    public string cardDescription;
    public int gameValue;

    public TMP_Text nameText;
    public TMP_Text designText;
    public TMP_Text buildText;
    public TMP_Text testText;
    public TMP_Text publishText;
    public TMP_Text descriptionText;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {

        numberOfCardsInDeck = DeckMSS.deckSize;

        DisplayCard[0] = CardMSSDatabase.studioCardList[displayId];
        id = DisplayCard[0].id;
        cardName = DisplayCard[0].cardName;
        design = DisplayCard[0].design;
        build = DisplayCard[0].build;
        test = DisplayCard[0].test;
        publish = DisplayCard[0].publish;
        genreColor = DisplayCard[0].genreColor;
        cardDescription = DisplayCard[0].cardDescription;
        gameValue = DisplayCard[0].gameValue;

        nameText.text = " " + cardName;
        designText.text = " " + design;
        buildText.text = " " + build;
        testText.text = " " + test;
        publishText.text = " " + publish;
        descriptionText.text = " " + cardDescription;

    }

    // Update is called once per frame
    void Update()
    {
        
        id = DisplayCard[0].id;
        cardName = DisplayCard[0].cardName;
        design = DisplayCard[0].design;
        build = DisplayCard[0].build;
        test = DisplayCard[0].test;
        publish = DisplayCard[0].publish;
        genreColor = DisplayCard[0].genreColor;
        cardDescription = DisplayCard[0].cardDescription;
        gameValue = DisplayCard[0].gameValue;

        nameText.text = " " + cardName;
        designText.text = " " + design;
        buildText.text = " " + build;
        testText.text = " " + test;
        publishText.text = " " + publish;
        descriptionText.text = " " + cardDescription;


        Hand = GameObject.Find("Hand");
        if(this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;

        if(this.tag == "Clone")
        {
            //DisplayCard[0] = DeckMSS.staticDeck[numberOfCardsInDeck - 1];
            numberOfCardsInDeck -= 1;
            DeckMSS.deckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }

    }
}
