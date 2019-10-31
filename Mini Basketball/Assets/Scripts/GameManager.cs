using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Timer getTime;
    // Start is called before the first frame update
    void Start()
    {
        ScoreTrack.score = 0;
        getTime.timeLeft = 100.0f;
        //Timer.timeLeft = 300.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
