using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite openSprite, closedSprite;
    bool canInteract;

    public string item;

    public InventoryManager inventory;
    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire2") && canInteract) {
            Debug.Log("Environment Interaction");
            if( sr.sprite == closedSprite ) {
                sr.sprite = openSprite;
                if( item != null ){
                    inventory.AddItem(item);
                    item = null;
                }
            }
            else {
                sr.sprite = closedSprite;
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
