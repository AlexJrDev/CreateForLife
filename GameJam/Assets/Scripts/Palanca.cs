using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour {


    [SerializeField]
    PlataformaFall MiPlataforma;

    [SerializeField]
    bool PalancaTrampa = false;

    private void OnTriggerStay2D(Collider2D jugador)
    {
        if (jugador.CompareTag("player") && Input.GetKeyDown(KeyCode.Space))
        {

            if(PalancaTrampa == false)
            {
                MiPlataforma.ElejirPunto = 0;
            } else
            {
                MiPlataforma.ElejirPunto = 1;
            }

            MiPlataforma.Activado = true;
            
        }
    }


}
