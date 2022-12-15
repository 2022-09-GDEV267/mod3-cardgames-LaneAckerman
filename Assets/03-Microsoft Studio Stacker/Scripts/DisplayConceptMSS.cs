using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayConceptMSS : MonoBehaviour
{
    public List<CardMSS> cDisplayCard = new List<CardMSS>();
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
    public TMP_Text genreText;
    public TMP_Text valueText;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject ConceptDeckPanel;
    public int cnumberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {

        cnumberOfCardsInDeck = ConceptDeckMSS.cDeckSize;

        cDisplayCard[0] = CardMSSDatabase.conceptCardList[displayId];
        id = cDisplayCard[0].id;
        cardName = cDisplayCard[0].cardName;
        design = cDisplayCard[0].design;
        build = cDisplayCard[0].build;
        test = cDisplayCard[0].test;
        publish = cDisplayCard[0].publish;
        genreColor = cDisplayCard[0].genreColor;
        cardDescription = cDisplayCard[0].cardDescription;
        gameValue = cDisplayCard[0].gameValue;

        nameText.text = " " + cardName;
        designText.text = " " + design;
        buildText.text = " " + build;
        testText.text = " " + test;
        publishText.text = " " + publish;
        descriptionText.text = " " + cardDescription;
        genreText.text = "Genre: " + genreColor;
        genreText.text = "Value: " + gameValue;

    }

    // Update is called once per frame
    void Update()
    {
        
        id = cDisplayCard[0].id;
        cardName = cDisplayCard[0].cardName;
        design = cDisplayCard[0].design;
        build = cDisplayCard[0].build;
        test = cDisplayCard[0].test;
        publish = cDisplayCard[0].publish;
        genreColor = cDisplayCard[0].genreColor;
        cardDescription = cDisplayCard[0].cardDescription;
        gameValue = cDisplayCard[0].gameValue;

        nameText.text = " " + cardName;
        designText.text = " " + design;
        buildText.text = " " + build;
        testText.text = " " + test;
        publishText.text = " " + publish;
        descriptionText.text = " " + cardDescription;


        ConceptDeckPanel = GameObject.Find("ConceptDeckPanel");
        if(this.transform.parent != ConceptDeckPanel.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;

        if(this.tag == "Clone")
        {
            cDisplayCard[0] = ConceptDeckMSS.staticCDeck[cnumberOfCardsInDeck - 1];
            cnumberOfCardsInDeck -= 1;
            ConceptDeckMSS.cDeckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }

    }
}
