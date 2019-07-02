using UnityEngine;

public class OpenExit : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite openExit, closedExit;
    public BoxCollider2D triggerBox;
    bool canOpenDoor;
    public int goldKeyReqs = 1;
    public InventoryManager inventoryManager;
    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire2") && canOpenDoor) {
            sr.sprite = openExit;
            triggerBox.enabled = false;
            inventoryManager.RemoveItem("key");
        }
    }

    public void OnTriggerEnter2D(){
        if(goldKeyReqs == 0 || inventoryManager.HasDoorReqs(goldKeyReqs)) {
            canOpenDoor = true;
        }

    }

    public void OnTriggerExit2D() {
        canOpenDoor = false;
    }
}
