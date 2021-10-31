using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPunto1 : MonoBehaviour
{
    bool habilitado = true;
    public GameObject punto1;

    private float siguienteTrabajo = 0;
    public float tiempoSiguiTra;

    // Start is called before the first frame update
    void Start()
    {
        siguienteTrabajo = Time.time + 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > siguienteTrabajo && habilitado)// Pasado el tiempo se puede ejecutar el codigo
        {
            punto1.SetActive(true);
            habilitado = false;
            
        }
        
    }

    public void HabilitarPunto1()
    {

        habilitado = true;
        siguienteTrabajo = Time.time + tiempoSiguiTra;
    }
}
