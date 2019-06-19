using UnityEngine;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void Restart(){
        FindObjectOfType<GameManager>().Restart();
    }

    public void QuitGame() {
        Application.Quit();
    }
}
