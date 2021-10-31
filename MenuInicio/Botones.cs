using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void Jugar()
    {
        GanarMonedas.monedas = 30;
        SceneManager.LoadScene(1);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(2);
    }

    public void MenuInicio()
    {
        SceneManager.LoadScene(0);
    }
}
