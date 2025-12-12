using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // <-- replace with your scene name
    }

    public void QuitGame()
    {
        Application.Quit();  // Only works in build
        Debug.Log("Quit Game pressed");
    }
}