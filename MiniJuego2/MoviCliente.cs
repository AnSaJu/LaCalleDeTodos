using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviCliente : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movimientoHorizontal;
    public float velocidad;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Destroy(gameObject, 10);
    }

        void FixedUpdate()
    {
        Movimiento();
    }

    private void Movimiento()
    {          

        rb.velocity = new Vector2(velocidad, 0) * Time.deltaTime;   

    }
}
