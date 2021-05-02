using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{

    public DialogueBox menu;
    public GameObject dialogueManager;
    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        sentences.Clear();
    }

    public void makeChoice() {
        dialogueManager.SetActive(false);
        menu.ShowMessageBox();
    }

    public void Hide() {
        dialogueManager.SetActive(false);
    }

    public void Show() {
        dialogueManager.SetActive(true);
    }
}
