using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConceptDeckMSS : MonoBehaviour
{

    public List<CardMSS> cContainer = new List<CardMSS>();
    public int cx;
    public static int cDeckSize;
    public List<CardMSS> cDeck = new List<CardMSS>();
    public static List<CardMSS> staticCDeck = new List<CardMSS>();

    /*
    public GameObject cardInStudioDeck1;
    public GameObject cardInStudioDeck2;
    public GameObject cardInStudioDeck3;
    public GameObject cardInStudioDeck4;
    */

    public GameObject GameConceptCard;
    public GameObject[] Clones;
    public GameObject AvailableConcepts;


    // Start is called before the first frame update
    void Start()
    {
        cx = 0;
        cDeckSize = 50;

        for (int i = 0; i < cDeckSize; i++)
        {
            cx = Random.Range(0, CardMSSDatabase.conceptCardList.Count);
            cDeck[i] = CardMSSDatabase.conceptCardList[cx];


        }


        StartCoroutine(GenConcepts());

    }

    // Update is called once per frame
    void Update()
    {
        staticCDeck = cDeck;

        /*
        if (cDeckSize < 19)
        {
            cardInStudioDeck1.SetActive(false);
        }

        if (cDeckSize < 13)
        {
            cardInStudioDeck2.SetActive(false);
        }

        if (cDeckSize < 7)
        {
            cardInStudioDeck3.SetActive(false);
        }

        if (cDeckSize < 1)
        {
            cardInStudioDeck4.SetActive(false);
        }
        */
    }

    IEnumerator GenConcepts()
    {
        for (int i = 0; i <= 2; i++)
        {
            yield return new WaitForSeconds(1);
            //NEW
            //AudioSource.PlayOneShot(draw, 1f);
            //NEW
            Instantiate(GameConceptCard, transform.position, transform.rotation);
        }
    }

    public void Shuffle()
    {
        for (int i = 0; i < cDeckSize; i++)
        {
            cContainer[0] = cDeck[i];
            int randomIndex = Random.Range(i, cDeckSize);
            cDeck[i] = cDeck[randomIndex];
            cDeck[randomIndex] = cContainer[0];
        }
    }

    public void DrawConcept()
    {
        Instantiate(GameConceptCard, transform.position, transform.rotation);
    }
}

