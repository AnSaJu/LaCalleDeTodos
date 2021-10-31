using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoCarro : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadCarro;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Destroy(gameObject, 15);
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    private void Movimiento()
    {

        rb.velocity = new Vector2(velocidadCarro, 0) * Time.deltaTime;

    }

    
}
