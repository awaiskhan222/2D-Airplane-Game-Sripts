using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileDestroyScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="enemey")
        {
            Destroy();
        }
    }
    private void Update()
    {
        Invoke("Destroy", 3f);
    }
    
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
