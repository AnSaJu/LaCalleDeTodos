using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GanarMonedas : MonoBehaviour
{

    public static int monedas = 30;
    private int auxMonedas;

    public Text textMonedas;

    float tiempo = 1f;

    

    // Start is called before the first frame update
    void Start()
    {
        auxMonedas = monedas;
        textMonedas.text = "" + monedas;
        
    }

    // Update is called once per frame
    void Update()
    {

        if(monedas > auxMonedas)
        {
            
            textMonedas.text = ""+ monedas;            
            auxMonedas = monedas;
            
        }
        else
        {
            tiempo -= Time.deltaTime;
            if(tiempo <= 0)
            {
                monedas--;
                textMonedas.text = "" + monedas;
                tiempo = Time.deltaTime + 1;
            }
            
        }

        if(monedas <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    
}
