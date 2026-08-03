using UnityEngine;

public class die : MonoBehaviour
{
    private int speed = 2;
    private int damage = 2;

    public int direction1 = 1;

    public avatarController avatarH;
    public simpsonController simpsonH;
    public gangsterController gangsterH;
    public helmetController helmetH;
    public hulkController hulkH;


    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * direction1 * speed);

    }

     public void SetDirection(int dir)
    {
        direction1 = dir;
        transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x) * dir, transform.localScale.y);
    } // new


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {


            if (simpsonH == null)
            {
                simpsonH = other.GetComponent<simpsonController>();
            }

            if (simpsonH != null)
            {
                simpsonH.TakeDamage(damage);
                Destroy(gameObject);
            }

            if (avatarH == null)
            {
                avatarH = other.GetComponent<avatarController>();
            }

            if (avatarH != null)
            {
                avatarH.TakeDamage(damage);
                Destroy(gameObject);

            }

            if (gangsterH == null)
            {
                gangsterH = other.GetComponent<gangsterController>();
            }

            if (gangsterH != null)
            {
                gangsterH.TakeDamage(damage);
                Destroy(gameObject);

            }

            if (helmetH == null)
            {
                helmetH = other.GetComponent<helmetController>();
            }

            if (helmetH != null)
            {
                helmetH.TakeDamage(damage);
                Destroy(gameObject);

            }

            if (hulkH == null)
            {
                hulkH = other.GetComponent<hulkController>();
            }

            if (hulkH != null)
            {
                hulkH.TakeDamage(damage);
                Destroy(gameObject);

            }
        }

    }
}

//im not satisfied for these. should short way.
