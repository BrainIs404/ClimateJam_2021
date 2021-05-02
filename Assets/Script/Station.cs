using System;
using UnityEngine;

public class Station : MonoBehaviour
{
    public DialogueBox dialogueBox;

    public GameObject player;

    void OnMouseDown() {
        Vector2 playerPos = player.transform.position;
        Vector2 stationPos = this.transform.position;
        Debug.Log("Station pos: " + stationPos);
        Debug.Log("Player pos: " + playerPos);

        if (playerPos.x <= (stationPos.x + 1) && playerPos.x >= (stationPos.x - 1)) {

            if (playerPos.y <= (stationPos.y + 1) && playerPos.y >= (stationPos.y - 1)) {

                dialogueBox.ShowMessageBox();
            }
        }
    }

    void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = new Color(0.990566f,0.8193185f,0.09812211f,0.3f);
    }
    
    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = new Color(0.990566f,0.8193185f,0.09812211f,0f);
    }
}
