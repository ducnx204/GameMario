using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Reward : MonoBehaviour
{
    public int cointValue = 100;

    public AudioSource aus;
    public AudioClip coiSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameControll.instance.AddScore(cointValue);
            if (aus && coiSound)
            {
                aus.PlayOneShot(coiSound);
            }

            Destroy(gameObject);
          
        }
    }
}
