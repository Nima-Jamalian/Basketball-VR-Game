using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _ballObject = default;
    [SerializeField]
    private GameObject _basketLocationLeft = default;
    [SerializeField]
    private GameObject _basketLocationRight = default;
    [SerializeField]
    private int _maxBallCount = 2;
    private int _ballCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SpawnBall();
    }

    void SpawnBall()
    {
        _ballCount = GameObject.FindGameObjectsWithTag("BasketBall").Length;
        if (_ballCount < _maxBallCount)
        {
            if(Random.Range(0,2) == 0)
            {
                Instantiate(_ballObject, _basketLocationRight.transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(_ballObject, _basketLocationLeft.transform.position, Quaternion.identity);
            }
        }
    }

}
