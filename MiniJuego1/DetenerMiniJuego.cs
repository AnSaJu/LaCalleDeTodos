using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetenerMiniJuego : MonoBehaviour
{
    public MoviPlayer moviPlayer;    

    private float siguienteMultiplicacion = 0;
    public float tiempoMultiplicacion;

    public ControlPunto1 controlPunto1;

    void Start()
    {
        siguienteMultiplicacion = Time.time + tiempoMultiplicacion;
    }

    // Update is called once per frame
    void Update()
    {        

        if (Time.time > siguienteMultiplicacion)// Pasado el tiempo se puede ejecutar el codigo
        {
            
            moviPlayer.enabled = enabled;
            controlPunto1.HabilitarPunto1();
            this.gameObject.SetActive(false);
        }
    }

    public void IniciarContador()
    {
        siguienteMultiplicacion = Time.time + tiempoMultiplicacion;
    }
}
