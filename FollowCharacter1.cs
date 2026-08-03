using UnityEngine;

public class FollowCharacter1 : MonoBehaviour
{
    public GameObject character1;
    private Vector3 offset = new Vector3(0, 0, -10);
    void Start()
    {
    }
    void Update()
    {
        transform.position = character1.transform.position + offset;
    }

  
}
