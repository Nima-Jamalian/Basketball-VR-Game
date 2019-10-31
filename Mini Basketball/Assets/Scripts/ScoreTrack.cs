using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Unity Engine UI
using UnityEngine.UI;

public class ScoreTrack : MonoBehaviour
{
    public static int score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score);
        scoreText.text = score.ToString();
    }

}
