using UnityEngine;
using UnityEngine.SceneManagement;

public class btnScript : MonoBehaviour
{
    //public method that quits out of the game
    public void QuitGame()
    {
        Application.Quit();
    }

    //public method that reloads the current scene
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
