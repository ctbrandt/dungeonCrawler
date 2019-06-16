using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter2D () {
        Debug.Log("Reached End");
        gm.CompleteLevel();
    }
}
