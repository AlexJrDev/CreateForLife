using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour {

    [SerializeField]
    string Escena;

    public Animator animadorUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(CargarEscena());
        }
    }

    IEnumerator CargarEscena()
    {
        animadorUI.SetBool("Iniciar",true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(Escena);
    }

}
