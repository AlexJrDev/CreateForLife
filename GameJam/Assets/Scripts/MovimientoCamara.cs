using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {

    [SerializeField]
    GameObject[] Jugadores;

    Vector2 Mipos;

    private void Update()
    {
        transform.position = new Vector3(((Jugadores[0].transform.position.x + Jugadores[1].transform.position.x)) / 2, 
        transform.position.y, transform.position.z);
    }
}
