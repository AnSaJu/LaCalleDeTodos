using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorComida : MonoBehaviour
{
    public GameObject comida;
    private bool generar = false;

    public Transform padre;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(generar)
        {
            Instantiate(comida, padre);
            generar = false;
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Instantiate(comida, padre);            
        
    }

    public void GenerarComida()
    {
        generar = true;
    }
}
