using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydestroy : MonoBehaviour
{
    private float timepass;
    private float speed = 4f;

    private void Update()
    {

        float movementSpeed = speed * Time.deltaTime;
        transform.Translate(0,- movementSpeed, 0);
        timepass += Time.deltaTime;
        if(timepass > 5f)
        {
            gameObject.SetActive(false);

            timepass = 0;
        }
        
    }

}
