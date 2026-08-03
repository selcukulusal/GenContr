using UnityEngine;

public class collectables : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindAnyObjectByType<objectCounter>().AddObject();
        }
    }

}
