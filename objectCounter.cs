using System.Diagnostics.Metrics;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class objectCounter : MonoBehaviour
{
    public TMP_Text objectname;
    private int objectCount = 0;
    private int totalitem = 12;
    public GameObject complete;



    public void AddObject()
    {
        objectCount++;
        objectname.text = " " + objectCount.ToString(); ;
        full();
    }

    public void full()
    {

        if (objectCount >= totalitem)
        {
            Complete();
        }
    }

    public void ClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Complete()
    {
        complete.SetActive(true);

    }

}
