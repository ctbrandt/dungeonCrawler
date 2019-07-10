using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    Queue<string> sentences;
    public GameObject player;
    public GameObject NarratorUI;
    public Text NarratorText;
    // Start is called before the first frame update

    public void StartDialogue(TextAsset dialogueText) {
        this.gameObject.SetActive(true);
        sentences = new Queue<string>();
        NarratorUI.SetActive(true);
        List<string> dialogue = TextAssetToList(dialogueText);

        //Disable player movement while Narrator talks
        EnablePlayer(false);
        StartNarrator(dialogue);
    }

    public void StartNarrator( List<string> dialogue){
        foreach(string sentence in dialogue) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    void Update() {

        if(Input.anyKeyDown) {
            DisplayNextSentence();
        }
    }
    public void DisplayNextSentence() {
        Debug.Log("DisplayNextSentence");
        if( sentences.Count == 0 ) {
            EndNarrator();
        } else {
            NarratorText.text = sentences.Dequeue();
        }
    }

    public void EndNarrator() {
        EnablePlayer(true);
        NarratorUI.SetActive(false);
        this.gameObject.SetActive(false);
    }

    public void EnablePlayer(bool enableFlag){
        player.GetComponent<PlayerMovement2D>().enabled = enableFlag;
    }
    private List<string> TextAssetToList(TextAsset ta) {
        return new List<string>(ta.text.Split('\n'));
    }

}
