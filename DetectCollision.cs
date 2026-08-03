using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("mainBullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("platform"))
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
