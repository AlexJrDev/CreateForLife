using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour {


    [SerializeField]
    PlataformaFall MiPlataforma;

    [SerializeField]
    bool PalancaTrampa = false;

    [SerializeField]
    bool Cambio = true;
    Animator MiAnimator;

    private void Start()
    {
        MiAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        MiAnimator.SetBool("Cambio", Cambio);
    }

    private void OnTriggerStay2D(Collider2D jugador)
    {
        if (jugador.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {

            if(PalancaTrampa == false)
            {
                MiPlataforma.ElejirPunto = 0;
            } else
            {
                MiPlataforma.ElejirPunto = 1;
            }

            MiPlataforma.Activado = true;
            Cambio = !Cambio;
            
        }
    }
}
