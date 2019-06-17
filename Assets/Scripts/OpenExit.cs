using UnityEngine;

public class OpenExit : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite openExit, closedExit;
    public BoxCollider2D triggerBox;
    bool canOpenDoor;
    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire2") && canOpenDoor) {
            Debug.Log("Open door action");
            sr.sprite = openExit;
            triggerBox.enabled = false;
        }
    }

    public void OnTriggerEnter2D(){
        canOpenDoor = true;
    }

    public void OnTriggerExit2D(){
        canOpenDoor = false;
    }
}
