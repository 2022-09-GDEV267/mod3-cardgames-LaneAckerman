using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        CardManagerMSS.LastEnteredDropzone = transform;


    }

    public void OnDrop(PointerEventData eventData)
    {
        //Drag.parentToReturnTo = this.transform.parent;
        Debug.Log("Drop");

    }

    public void OnPointerExit(PointerEventData eventData)
    {



    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
