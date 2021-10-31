using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoviPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movimientoHorizontal;
    private float movimientoVertical;
    public float velocidad;

    bool muerto = false;
    Animator animacion;

    public AnimacionPlayer animacionPlayer;
    public AudioSource sonidoDestruir;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
        sonidoDestruir = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        muerto = false;
    }


    void FixedUpdate()
    {       
            Movimiento();       
    }

    private void Movimiento()
    {
        if (!muerto)
        {
            movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidad;
            movimientoVertical = Input.GetAxisRaw("Vertical") * velocidad;

            rb.velocity = new Vector2(movimientoHorizontal, movimientoVertical) * Time.deltaTime;
        }
        

        //if (movimientoHorizontal != 0)
        //rb.velocity = new Vector2(movimientoHorizontal, 0) * Time.deltaTime;
        //else
        //    rb.velocity = new Vector2(0, movimientoVertical) * Time.deltaTime;

    }

   public void DetenerMovi()
    {
        rb.velocity = Vector2.zero ;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Carro"))
        {
            muerto = true;
            DetenerMovi();
            animacionPlayer.IniciarAnimacion();
            sonidoDestruir.Play();

            //animacion.SetBool("muertoAni", muerto);
            //Invoke("CargarMenu", 3);
        }

    }

    //void CargarMenu()
    //{
    //    SceneManager.LoadScene(0);
    //}
}
