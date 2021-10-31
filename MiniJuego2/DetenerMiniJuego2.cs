using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetenerMiniJuego2 : MonoBehaviour
{
    public MoviPlayer moviPlayer;

    private float siguienteMultiplicacion = 0;
    public float tiempoDeMiniJuego;

    public ControlPunto2 controlPunto2;

    void Start()
    {
        siguienteMultiplicacion = Time.time + tiempoDeMiniJuego;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > siguienteMultiplicacion)// Pasado el tiempo se puede ejecutar el codigo
        {

            moviPlayer.enabled = enabled;
            controlPunto2.HabilitarPunto2();
            this.gameObject.SetActive(false);
        }
    }

    public void IniciarContador()
    {
        siguienteMultiplicacion = Time.time + tiempoDeMiniJuego;
    }
}
