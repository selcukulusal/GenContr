using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public GameObject gameoverui;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

public void gameoverF()
    {
        gameoverui.SetActive(true);
    }

    public void RestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
