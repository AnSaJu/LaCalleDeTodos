using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimacionPlayer : MonoBehaviour
{

    Animator animacion;

    private void Awake()
    {
       
        animacion = GetComponent<Animator>();
    }

   

    public void IniciarAnimacion()
    {        
            animacion.SetBool("muertoAni", true);
            Invoke("CargarMenu", 3);      

    }

    void CargarMenu()
    {
        SceneManager.LoadScene(0);
    }
}
