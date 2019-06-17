using UnityEngine;
using UnityEngine.SceneManagement;
public class Victory : MonoBehaviour
{
    public void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
