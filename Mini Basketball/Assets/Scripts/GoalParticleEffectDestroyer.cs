using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalParticleEffectDestroyer : MonoBehaviour
{
    [SerializeField]
    private float _goldParticleEffectLifeTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_goldParticleEffectLifeTime > 0)
        {
            _goldParticleEffectLifeTime -= Time.deltaTime;
            if(_goldParticleEffectLifeTime <= 0)
            {
                Destruction();
            }
        }
    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
