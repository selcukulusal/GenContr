using UnityEngine;

public class retunfromhulk : MonoBehaviour
{
    private int speed = 1;
    private float max = -0.506f;
    private float start = 3.056f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        
        if (transform.position.x < max)
        {
            transform.position = new Vector2(start, transform.position.y);
        }
    }
}
