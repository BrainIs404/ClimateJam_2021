using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    public static bool MessageOnScreen = false;
    public GameObject MessageBox;

    // Update is called once per frame
    void Update()
    {
        int counter = 5;
        if (counter == 5)
        {
            if (MessageOnScreen)
            {
                Debug.Log("Message on screen");
                //HideMessageBox();
            }
            else
            {
                GameObject.Find("DialogueBox").SetActive(true);
            }
        }
    }
}
