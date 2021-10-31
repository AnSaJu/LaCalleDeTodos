using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto2 : MonoBehaviour
{
    public MoviPlayer moviPlayer;
    public GameObject miniJuego;
    public DetenerMiniJuego2 detenerMiniJuego2;
    public GeneradorComida[] generadorComida;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            moviPlayer.DetenerMovi();
            moviPlayer.enabled = false;

            miniJuego.SetActive(true);
            detenerMiniJuego2.IniciarContador();
            generadorComida[0].GenerarComida();
            generadorComida[1].GenerarComida();
            generadorComida[2].GenerarComida();
            gameObject.SetActive(false);
            Debug.Log("Inicia miniJuego #2");
        }
    }
}
