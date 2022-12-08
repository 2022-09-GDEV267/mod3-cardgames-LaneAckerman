using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckMSS : MonoBehaviour
{

    public List<CardMSS> container = new List<CardMSS>();
    public int x;
    public static int deckSize;
    public List<CardMSS> deck = new List<CardMSS>();
    public static List<CardMSS> staticDeck = new List<CardMSS>();

    public GameObject cardInStudioDeck1;
    public GameObject cardInStudioDeck2;
    public GameObject cardInStudioDeck3;
    public GameObject cardInStudioDeck4;

    public GameObject StudioCardToHand;
    public GameObject[] Clones;
    public GameObject Hand;


    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 24;

        for(int i = 0; i<deckSize; i++)
        {
            x = Random.Range(0, CardMSSDatabase.studioCardList.Count);
            deck[i] = CardMSSDatabase.studioCardList[x];


        }


        StartCoroutine(StartGame());
        
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;

        if (deckSize < 19)
        {
            cardInStudioDeck1.SetActive(false);
        }

        if (deckSize < 13)
        {
            cardInStudioDeck2.SetActive(false);
        }

        if (deckSize < 7)
        {
            cardInStudioDeck3.SetActive(false);
        }

        if (deckSize < 1)
        {
            cardInStudioDeck4.SetActive(false);
        }
    }

    IEnumerator StartGame()
    {
        for(int i = 0; i <=4; i++)
        {
            yield return new WaitForSeconds(1);
            //NEW
            //AudioSource.PlayOneShot(draw, 1f);
            //NEW
            Instantiate(StudioCardToHand, transform.position, transform.rotation);
        }
    }

    public void Shuffle()
    {
        for(int i = 0; i < deckSize; i++)
        {
            container[0] = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container[0];
        }
    }
}
