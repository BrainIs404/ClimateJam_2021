using System.Collections.Generic;
using System;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{
    public static bool MessageOnScreen = false;

    public GameObject menu;

    public PathFollower[] pathToFollow;

    private int counter = 0;

    Dictionary<string, float> moveSpeed = new Dictionary<string, float>();

    private void Start() {
        moveSpeed.Add("Bus", 5f);
        moveSpeed.Add("Bike", 3f);
        moveSpeed.Add("Train", 10f);
    }

    public void HideMessageBox() {
        menu.SetActive(false);
    }

    public void ShowMessageBox() {
        menu.SetActive(true);
    }

    public void Move(string choice) {

        HideMessageBox();
        pathToFollow[counter].canMove(moveSpeed[choice]);
        counter = (counter + 1) % pathToFollow.Length;
    }

}
