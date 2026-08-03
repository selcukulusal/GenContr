using UnityEngine;
using UnityEngine.SceneManagement;

public class missionComplete : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int totalbottle = 12;
    private int bottles = 0;
    public GameObject complete;


    public void IcecekTopla()
    {
        bottles++;

        if (bottles >= totalbottle)
        {
            complete.SetActive(true);
        }
    }

  
}