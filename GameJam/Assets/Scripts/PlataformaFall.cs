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

    //Se eleje desde palanca
    public int ElejirPunto;


    private void FixedUpdate()
    {
        Movimiento();
    }


    void Movimiento()
    {
        if (Activado == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, PuntoAMoverse[ElejirPunto].transform.position, VelocidadMovimiento * Time.deltaTime);
        }
    }

}
