using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {

    [SerializeField]
    GameObject[] Jugadores;

    Vector2 Mipos;
    //Minimo y maximo de pos
    [SerializeField]
    float[] posMinMax;

    Vector3 PosTemporal;

    private void Update()
    {
        PosTemporal = new Vector3(((Jugadores[0].transform.position.x + Jugadores[1].transform.position.x)) / 2,
        transform.position.y, transform.position.z);

        if (PosTemporal.x > posMinMax[0] && transform.position.x < posMinMax[1])
        {
            transform.position = PosTemporal;
        }
    }
}
