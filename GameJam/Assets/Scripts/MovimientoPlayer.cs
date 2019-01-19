using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour {

    public float Velocidad;
    public float FuerzaSalto;
    public float MovimientoInput;

    Rigidbody2D MiRb;

    bool ViendoLadoDerecho;

    //Para Saber si puede saltar
    bool TocandoSuelo;
    public Transform ComprobadorSuelo;
    public float RadioTocarSuelo;
    public LayerMask Suelo;

    //0 para solo tener un salto, 1 para tener doble salto
    private int SaltosExtra;
    public int CantidadDeSaltosExtra;

    [SerializeField]
    bool PersonajeSuperior = true;

    void Start()
    {
        MiRb = GetComponent<Rigidbody2D>();
        SaltosExtra = CantidadDeSaltosExtra;
    }

    void FixedUpdate()
    {
        if (PersonajeSuperior == true)
        {
            TocandoSuelo = Physics2D.OverlapCircle(ComprobadorSuelo.position, RadioTocarSuelo, Suelo);
        }

        MovimientoInput = Input.GetAxis("Horizontal");
        MiRb.velocity = new Vector2(MovimientoInput * Velocidad, MiRb.velocity.y);

        if (ViendoLadoDerecho == true && MovimientoInput < 0)
        {
            GirarVista();
        }
        if (ViendoLadoDerecho == false && MovimientoInput > 0)
        {
            GirarVista();
        }

    }

    private void Update()
    {
        if (TocandoSuelo == true)
        {
            SaltosExtra = CantidadDeSaltosExtra;
        }

        //Para Salto (Solo el personase superior Puede saltar)
        if (PersonajeSuperior == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && SaltosExtra > 0)
            {
                MiRb.velocity = Vector2.up * FuerzaSalto;
                SaltosExtra--;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.W)) && SaltosExtra == 0 && TocandoSuelo == true)
            {
                MiRb.velocity = Vector2.up * FuerzaSalto;
            }
        } 

        //Para Agacharse (Solo el personaje inferior puede saltar)
        if (PersonajeSuperior == false)
        {
            //Para agacharse
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)){

                //Cambiar Collider Para poder pasar por debajo
                GetComponent<BoxCollider2D>().offset = new Vector2(0, -0.15f);
                GetComponent<BoxCollider2D>().size = new Vector2(0.64f, 0.3207791f);

            }

            //Para Levantarse
            if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
            {

                //Cambiar Collider Para levantarse
                GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);
                GetComponent<BoxCollider2D>().size = new Vector2(0.64f, 0.64f);

            }
        }
    }

    void GirarVista()
    {
        ViendoLadoDerecho = !ViendoLadoDerecho;
        Vector3 Escala = transform.localScale;
        Escala.x *= -1;
        transform.localScale = Escala;
    }
}
