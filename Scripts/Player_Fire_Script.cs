using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire_Script : MonoBehaviour
{
    [SerializeField] private GameObject[] missills;
    [SerializeField] private Transform refrencepointofmissile;
    

    [SerializeField] private float timeafterattack;
    [SerializeField] private float attackTimer =Mathf.Infinity;
    // The object to instantiate
    private BoxCollider2D boxCollider;
    


    

    // The speed of the object
    public float speed = 5.0f;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        
    }
    private void Update()
    {
        
        attackTimer += Time.deltaTime;

        // to activate the enemey again after deactive
        /*GameObject obj = GameObject.FindGameObjectWithTag("enemey");
        if (!obj.activeInHierarchy)
        {
            

            obj.SetActive(true);
        }*/
        
    }

    public void FireCreator()
    {
        if(attackTimer > timeafterattack)
        {
            missills[Findmissile()].transform.position = refrencepointofmissile.position;
            missills[Findmissile()].gameObject.SetActive(true);

            attackTimer = 0;
        }
        
            
    }

    private int Findmissile()
    {
        for (int i = 0; i < missills.Length; i++)
        {
            if (!missills[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
    

    
}
