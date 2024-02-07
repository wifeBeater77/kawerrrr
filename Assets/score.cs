using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class score : MonoBehaviour
{
    public TextMeshProUGUI score1Text;
    public TextMeshProUGUI score2Text;
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    public TextMeshProUGUI Text;
    public float dt = 3f;
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] float remainingtime;

    int score1 = 0;
    int score2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text.gameObject.SetActive(false);
        Text1.gameObject.SetActive(false); 
        Text2.gameObject.SetActive(false);
        Text3.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingtime > 0)
        {
            remainingtime -= Time.deltaTime;
        }
        else if (remainingtime < 0)
        {
            remainingtime = 0;
            if (score1 > score2)
            {
                Text1.gameObject.SetActive(true);
            }
            else if (score2 > score1) 
            {
                Text2.gameObject.SetActive(true);
            }
            else
            {
                Text3.gameObject.SetActive(true);
            }

        }
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        timertext.text = string.Format("{0:00}:{1:00}",minutes,seconds);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("cage1"))
        {
            score2++;
            score2Text.text = "Away : " + score2.ToString();
            Text.gameObject.SetActive(true);
            Invoke("show", dt);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("cage2"))
        {
            score1++;
            score1Text.text = "Home : " + score1.ToString();
            Text.gameObject.SetActive(true);
            Invoke("show", dt);
        }
    }
    
private void show()
    {
        Text.gameObject.SetActive(false);
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }

}
