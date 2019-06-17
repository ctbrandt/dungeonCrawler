using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    // Start is called before the first frame update
    public void EndGame() {
        if( !gameOver ){
            Debug.Log("GAME OVER");
            gameOver = true;
            // Restart game
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel( ){
        completeLevelUI.SetActive(true);
    }

    public void Restart() {
        SceneManager.LoadScene(1);
    }
}
