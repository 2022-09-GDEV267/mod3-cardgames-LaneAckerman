using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConceptCardBack : MonoBehaviour
{

    public GameObject cCardBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (DisplayConceptMSS.staticCCardBack == true)
        {
            cCardBack.SetActive(true);
        }
        else
        {
            cCardBack.SetActive(false);
        }

    }
}
