using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverComida : MonoBehaviour
{
    private bool esCorrecto = false;

    private bool estaAgarrado = false;
    public int numeroComida;

    public GameObject monedaGanadora;
    public Vector3 pocicionMoneda;

    public void OnMouseDown()
    {
        estaAgarrado = true;
    }

    public void OnMouseUp()
    {
        estaAgarrado = false;
        if (esCorrecto)
        {            
            GanarMonedas.monedas += 2;
            Instantiate(monedaGanadora, pocicionMoneda, Quaternion.identity);
            Destroy(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 17);
    }

    // Update is called once per frame
    void Update()
    {
        if (estaAgarrado)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Comida"+ numeroComida))
        {
            esCorrecto = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Comida" + numeroComida))
        {
            esCorrecto = false;
            
        }
    }

}
    
