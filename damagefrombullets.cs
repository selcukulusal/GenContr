using UnityEngine;

public class damagefrombullets : MonoBehaviour
{
    public int damage = 3;
    public Health playerhealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerhealth == null)
            {
                playerhealth = other.GetComponent<Health>();
            }

            if (playerhealth != null)
            {
                Destroy(gameObject);
                playerhealth.TakeDamage(damage);
            }
        }
    }
}