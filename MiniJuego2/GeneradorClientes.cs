using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorClientes : MonoBehaviour
{
    private float siguienteCliente = 0;
    public float tiempoCliente;

    public GameObject[] cliente;
    private int numeroCliente;
    public Transform posicionInicial;

    void Start()
    {
        siguienteCliente = Time.time + tiempoCliente;
        numeroCliente = Random.Range(0,3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > siguienteCliente)// Pasado el tiempo se puede ejecutar el codigo
        {
            numeroCliente = Random.Range(0, 3);
            //Instantiate(cliente[numeroCliente], posicionInicial.position, Quaternion.identity);
            Instantiate(cliente[numeroCliente], posicionInicial);

            siguienteCliente = Time.time + tiempoCliente;
        }

    }
}
