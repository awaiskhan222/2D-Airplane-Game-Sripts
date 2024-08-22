using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthbarScript : MonoBehaviour
{
    [SerializeField] public Player_Health_script playerhealth;
    [SerializeField] private Image totalhealthbar;
    [SerializeField] private Image currenthealthbar;

    public void Start()
    {
        totalhealthbar.fillAmount = playerhealth.currenthealth / 10;
    }
    // Update is called once per frame
    public void Update()
    {
        currenthealthbar.fillAmount = playerhealth.currenthealth / 10;
    }
}
