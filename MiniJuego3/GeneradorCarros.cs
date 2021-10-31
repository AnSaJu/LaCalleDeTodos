using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorCarros : MonoBehaviour
{
    private float SiguienteCarro = 0;
    private float tiempoCarro;

    public GameObject[] Carro;
    private int NumeroDeCarro;
    public Transform posicionInicial;

    void Start()
    {
        tiempoCarro = Random.Range(1, 2);
        SiguienteCarro = Time.time + tiempoCarro;
        NumeroDeCarro = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > SiguienteCarro)// Pasado el tiempo se puede ejecutar el codigo
        {
            NumeroDeCarro = Random.Range(0, 3);
            tiempoCarro = Random.Range(2, 4);
            //Instantiate(cliente[numeroCliente], posicionInicial.position, Quaternion.identity);
            Instantiate(Carro[NumeroDeCarro], posicionInicial);

            SiguienteCarro = Time.time + tiempoCarro;
        }

    }
}
