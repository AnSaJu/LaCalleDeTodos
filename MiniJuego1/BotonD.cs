using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonD : MonoBehaviour
{
    private bool activo = false;
    private GameObject otro;

    public GameObject monedaGanadora;
    public Transform pocicionMoneda;

    public AudioSource sonidoGanar;

    void Awake()
    {

        sonidoGanar = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && activo)
        {
            activo = false;
            Instantiate(monedaGanadora, pocicionMoneda);
            GanarMonedas.monedas+=2;
            sonidoGanar.Play();
            Destroy(otro);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Boton"))
        {

            
            activo = true;
            otro = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        activo = false;
    }
}
