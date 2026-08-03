using UnityEngine;

public class blockBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("enemyBullet"))
        {
            {
                Destroy(other.gameObject);
            }

        }

        if (other.gameObject.CompareTag("mainBullet"))
        {
            {
                Destroy(other.gameObject);
            }
        }

        if (other.gameObject.CompareTag("bottleD"))
        {

            Destroy(other.gameObject);
        }
    }

}

