using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player_Health_script : MonoBehaviour
{
    
    [SerializeField] private float startinghealth;
    public GameObject Gamover_UI_Image;
    public float currenthealth;
    int score;
    public Text score_text1;
    public Text score_text2;
    private void Start()
    {
        currenthealth = startinghealth;
        Time.timeScale = 1;
    }
    public void Update()
    {
        if(currenthealth == 0)
        {
            Gamover_UI_Image.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    public void TakeDamage(float _damage)
    {
        currenthealth = Mathf.Clamp(currenthealth - _damage,0,startinghealth);
    }

    public void healthbtn()
    {
        TakeDamage(1);
    }

    public void TakHealth(float _health)
    {
        currenthealth = Mathf.Clamp(currenthealth +_health, 0, startinghealth);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemey")
        {
            TakeDamage(1);
        }

    }

    public void ScoreFunction()
    {
        score++;
        score_text1.text = score.ToString();
        score_text2.text = score.ToString();


    }

    public void RestartGame(int n)
    {
        SceneManager.LoadScene(n);
    }
    public void  Gamgequit()
    {
        Application.Quit();

    }


}
