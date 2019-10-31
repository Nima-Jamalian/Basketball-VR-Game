using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    [SerializeField]
    private AudioSource _goalSound = default;
    [SerializeField]
    private ParticleSystem _goalParticleEffect = default;
    [SerializeField]
    private int _ballDestroyDelayTime = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hoop")
        {
            _goalSound = GetComponent<AudioSource>();
            _goalSound.Play(0);
            ParticleEffect();
            ScoreTrack.score += 1;
            //Debug.Log("Goal!!!");
            //Debug.Log(ScoreTrack.score);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //delay execution of method
            StartCoroutine("DelayDestruction");
            //Destruction();
        }
    }

    void ParticleEffect()
    {
        Instantiate(_goalParticleEffect);
        _goalParticleEffect.Play();
    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }

    //Declaring Ienumerator
    //Used for delaying execution of method
    IEnumerator DelayDestruction()
    {
        yield return new WaitForSeconds(_ballDestroyDelayTime);
        Destruction();
    }
}
