using UnityEngine;

public class OpenExit : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite openExit, closedExit;
    public BoxCollider2D triggerBox;
   // bool isClosed;
    // Update is called once per frame
    void Update() {
        if(Input.GetButtonDown("Fire2")) {
            Debug.Log("Open door action");
            sr.sprite = openExit;
            triggerBox.enabled = false;
        }
    }
}
