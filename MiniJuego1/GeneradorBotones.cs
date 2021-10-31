using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBotones : MonoBehaviour
{

    public GameObject[] boton;
    public Transform[] puntoDePartida;
    public int cantidadBotones;
    public float prosimoBoton;
    public float comenzarBotones;
    public float prosimaOleada;

    public bool abilitar = false;
    int item; 

    void Start()
    {
        
        //StartCoroutine(GenerarBotones());
    }

    void Update()
    {
        if (abilitar)
        {
            StartCoroutine(GenerarBotones());
            abilitar = false;
        }
        
    }

    IEnumerator GenerarBotones()
    {
        yield return new WaitForSeconds(comenzarBotones);
        while (true)
        {
            for (int i = 0; i < cantidadBotones; i++)
            {
                item = Random.Range(0, 3);
                Vector3 posicionAsteroide = puntoDePartida[item].position;
                //Vector3 posicionAsteroide = new Vector3(Random.Range(-1.5f, 0.3f), 0f);
                Instantiate(boton[item], posicionAsteroide, Quaternion.identity);
                yield return new WaitForSeconds(prosimoBoton);
            }
            yield return new WaitForSeconds(prosimaOleada);
        }
    }


}
