using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtl : MonoBehaviour
{

    private ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        Destroy(this.gameObject, particle.main.duration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
