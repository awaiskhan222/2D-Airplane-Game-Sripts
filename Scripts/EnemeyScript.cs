using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyScript : MonoBehaviour
{
    Player_Health_script playerhealth;
    public AudioSource audiosource;
    public AudioClip blast_audio;

    private void Start()
    {
        playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Health_script>();
        blast_audio = GetComponent<AudioClip>();
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {

            playerhealth.ScoreFunction();
            gameObject.SetActive(false);
            audiosource.PlayOneShot(blast_audio);
            

        }

    }

}
