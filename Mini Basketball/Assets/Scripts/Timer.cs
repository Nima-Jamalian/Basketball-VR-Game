using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Loading the Scene Manager
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public so I can convet it to string
    public float timeLeft;
    public Text timeLeftText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timeLeftText.text = timeLeft.ToString("F0");
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        //Debug.Log(_timeLeft);
        if (timeLeft <= 0)
        {
            timeLeft = 0.0f;
            SceneManager.LoadScene("EndScreen");
            //Debug.Log("Time is over");
        }
    }
}
