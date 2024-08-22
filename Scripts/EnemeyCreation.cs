using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemeyCreation : MonoBehaviour
{

    [SerializeField] private GameObject[] enemeyplane;
    /*[SerializeField] private Transform refrencepointofenemey;*/
   

    [SerializeField] private float timeafterattack;
    [SerializeField] private float attackTimer = Mathf.Infinity;
    /*public GameObject EnemeyAirplane;

    public GameObject pointofenemeycreation;*/
    /*public Vector2 direction = new Vector2(0, -1);*/

    
    public float speed = 2.0f;

    private void Start()
    {
        InvokeRepeating("EnemeyCreator", 2f, 4f);
    }
    private void Update()
    {
        attackTimer +=Time.deltaTime;
        EnemeyCreator();
    }

    public void EnemeyCreator()
    {
        if(attackTimer > timeafterattack)
        {
            /*enemeyplane[Findenemy()].transform.position = refrencepointofenemey.position;*/
            enemeyplane[Findenemy()].transform.position = new Vector2(Random.Range(-2,2),6);
            enemeyplane[Findenemy()].gameObject.SetActive(true);
            attackTimer = 0;
        }
        
    }

    private int Findenemy()
    {
        for (int i = 0; i < enemeyplane.Length; i++)
        {
            if (!enemeyplane[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
    
}
