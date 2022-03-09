using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    private int kiwis = 0;
    private int bananas = 0;
    private int points = 0;
    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource pointSound;
    
    private void Update()
    {
        OnTriggerEnter2D(GetComponent<Collider2D>());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry")|| collision.gameObject.CompareTag("Kiwi")|| collision.gameObject.CompareTag("Banana"))
        {
            pointSound.Play();
            Destroy(collision.gameObject);
            if (collision.gameObject.CompareTag("Cherry"))
            {
                cherries++;
                //points = +cherries;
                points++;
            }
            else if(collision.gameObject.CompareTag("Kiwi"))
            {
                kiwis = +10;
                points = points + 10;
            }
            else if (collision.gameObject.CompareTag("Banana"))
            {
                bananas = +20;
                points = points + 20;
            }
            cherriesText.text = "Points: " + points;
        }
        
    }
}
