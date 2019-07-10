using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public DialogueManager dm;

    public TextAsset dialogueText;
    public bool requireInteraction;
    bool enableDialogue = false;
    
    // Start is called before the 
    public void OnTriggerEnter2D() {
        Debug.Log("In the trigger for dialog");
        enableDialogue = true;
        if(!requireInteraction) {
            TriggerDialogueManager();
        } 
    }

    public void OnTriggerExit2D() {
        enableDialogue = false;
    }

    public void Update() {
        if(enableDialogue && Input.GetButtonDown("Fire2")) {
            TriggerDialogueManager();
        } 
    }

    void TriggerDialogueManager() {
        dm.StartDialogue(dialogueText);
        this.gameObject.SetActive(false);
    }

}
