using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag: MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    //public static Transform parentToReturnTo = null;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        //parentToReturnTo = this.transform.parent;
        //this.transform.SetParent(this.transform.parent.parent);
        //Debug.Log("BeginDrag");
        this.image.raycastTarget = false;
        this.transform.SetParent(transform.root);
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {

        //this.transform.position = eventData.position;
        //Debug.Log("Drag");
        this.transform.position = Input.mousePosition;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //this.transform.SetParent(parentToReturnTo);
        //Debug.Log("EndDrag");
        this.transform.SetParent(CardManagerMSS.LastEnteredDropzone);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        this.image.raycastTarget = true;

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
