using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class destination : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void OnMouseUp ()
    {
        FindObjectOfType<ClickToMove>().GoToDestination(this);
        

    }
    public void PlayerArrived()
    {
        //Dialogue box appears
        FindObjectOfType<DialogueBox>().gameObject.SetActive(true);

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
