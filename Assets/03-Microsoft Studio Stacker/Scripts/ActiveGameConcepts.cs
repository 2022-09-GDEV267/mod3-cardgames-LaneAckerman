using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGameConcepts : MonoBehaviour
{

    public GameObject AConcept;
    public GameObject GCCard;

    // Start is called before the first frame update
    void Start()
    {
        RevealConcepts();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Hand = GameObject.Find("Hand");
        HandCard.transform.SetParent(Hand.transform);
        HandCard.transform.localScale = Vector3.one;
        HandCard.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        HandCard.transform.eulerAngles = new Vector3(25, 0, 0);
        */
    }

    public void RevealConcepts()
    {
        AConcept = GameObject.Find("AvailableConcepts");
        GCCard.transform.SetParent(AConcept.transform);
        GCCard.transform.localScale = Vector3.one;
        GCCard.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        GCCard.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
