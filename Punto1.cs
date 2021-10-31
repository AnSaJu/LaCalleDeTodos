using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punto1 : MonoBehaviour
{
    public GameObject miniJuego;
    public MoviPlayer moviPlayer;
    public GeneradorBotones generadorBotones;
    public DetenerMiniJuego detenerMiniJuego;

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            moviPlayer.DetenerMovi();
            moviPlayer.enabled = false;
            miniJuego.SetActive(true);
            generadorBotones.abilitar = true;
            detenerMiniJuego.IniciarContador();
            Debug.Log("Inicia miniJuego #1 ");
            gameObject.SetActive(false);
        }
    }
}
