using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public GameManager gm;
    public GameObject player;
    void OnTriggerEnter2D () {
        Debug.Log("Reached End");
        player.GetComponent<PlayerMovement2D>().enabled = false;
        gm.CompleteLevel();
    }
}
