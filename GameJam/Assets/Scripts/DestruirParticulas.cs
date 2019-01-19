using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirParticulas : MonoBehaviour {

    void Start()
    {
        //Destruir Particulas en el tiempo de vida maxima
        Destroy(gameObject, GetComponent<ParticleSystem>().main.duration + GetComponent<ParticleSystem>().main.startLifetime.constantMax + GetComponent<ParticleSystem>().main.startDelay.constant);
    }
}
