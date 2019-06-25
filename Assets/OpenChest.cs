using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite currSprite, nextSprite;
    bool canInteract;
    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire2") && canInteract) {
            Debug.Log("Environment Interaction");
            if( sr.sprite == currSprite ) {
                sr.sprite = nextSprite;
            }
            else {
                sr.sprite = currSprite;
            }
        }
    }

    public void OnTriggerEnter2D(){
        canInteract = true;
    }

    public void OnTriggerExit2D(){
        canInteract = false;
    }
}
