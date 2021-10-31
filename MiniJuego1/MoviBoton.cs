using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviBoton : MonoBehaviour
{

    public float velocidad = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Start()
    {
        Destroy(this.gameObject, 10f);
        rb.velocity = new Vector2(rb.velocity.x, velocidad);
    }

 }
