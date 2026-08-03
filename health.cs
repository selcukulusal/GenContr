using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int myhealth;
    public int maxhealth = 10;
    public PlayerController justdeadsound;
    public AudioSource sound;
    public AudioClip hurt;
    public gameover gameoverui;
    public Slider healthslider;

    void Start()
    {
        myhealth = maxhealth;
        healthslider.maxValue = maxhealth;
        healthslider.value = myhealth;
        justdeadsound = GetComponent<PlayerController>();
        sound = GetComponent<AudioSource>();


    }

    void Update()
    {

    }

    public void TakeDamage(int lvl)
    {
        myhealth -= lvl;
        healthslider.value = myhealth;

        if (myhealth <= -0)
        {
            Destroy(gameObject);
            gameoverui.gameoverF();

        }
    }
}

