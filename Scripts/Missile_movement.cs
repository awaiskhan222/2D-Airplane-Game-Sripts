using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_movement : MonoBehaviour
{
    private float timepass;
    private float speed = 5f;

    private void Update()
    {

        float movementSpeed = speed * Time.deltaTime;
        transform.Translate(0, movementSpeed, 0);
        timepass += Time.deltaTime;
        if (timepass > 5)
        {
            gameObject.SetActive(false);

            timepass = 0;
        }

        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="enemey") 
        {
            gameObject.SetActive(false);
        }
    }
}
