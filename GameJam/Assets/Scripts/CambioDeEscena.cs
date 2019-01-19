using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour {

    [SerializeField]
    string Escena;

    public Animator animadorUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(CargarEscena());
        }
    }

    IEnumerator CargarEscena()
    {
        animadorUI.SetTrigger("Iniciar");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(Escena);
    }

}
