using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaFall : MonoBehaviour {

    //fFunciona con palanca*

    [SerializeField]
    GameObject[] PuntoAMoverse;

    public bool Activado;

    [SerializeField]
    float VelocidadMovimiento;

    [SerializeField]
    bool Caible = false;

    //Se eleje desde palanca
    public int ElejirPunto;


    private void FixedUpdate()
    {
        Movimiento();
    }

    private void OnCollisionEnter2D(Collision2D otro)
    {
        if (Caible == true)
        {
            if (otro.gameObject.tag == "Player")
            {
                Activado = true;
            }
        }
    }


    void Movimiento()
    {
        if (Activado == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, PuntoAMoverse[ElejirPunto].transform.position, VelocidadMovimiento * Time.deltaTime);
        }
    }

}
