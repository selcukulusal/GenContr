using Unity.VisualScripting;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{


    private GameObject currentTeleporter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("teleporter")) 
        {
            if (collision.gameObject == currentTeleporter) 
            {
                currentTeleporter = null;
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter
                .GetComponent<Teleporter>()
                .GetDestination().position;
            }
        }
    }
}



