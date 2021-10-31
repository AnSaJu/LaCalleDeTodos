using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPunto2 : MonoBehaviour
{
    bool habilitado = true;
    public GameObject punto2;

    private float siguienteTrabajo = 0;
    public float tiempoSiguiTra;

    // Start is called before the first frame update
    void Start()
    {
        siguienteTrabajo = Time.time + 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > siguienteTrabajo && habilitado)// Pasado el tiempo se puede ejecutar el codigo
        {
            punto2.SetActive(true);
            habilitado = false;

        }

    }

    public void HabilitarPunto2()
    {

        habilitado = true;
        siguienteTrabajo = Time.time + tiempoSiguiTra;
    }
}
