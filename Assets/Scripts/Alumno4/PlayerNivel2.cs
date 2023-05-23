using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerNivel2 : Personaje
{
    private bool perdio;
    private float distanciaRecorrida;
    public new Rigidbody rigidbody;
    public float velocidad = 2;
    private Vector3 posicionInicial;

    public Text distanciaText;

    public void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        posicionInicial = transform.position;
    }

    private void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal"); 
        float movimientoVertical = Input.GetAxis("Vertical");
        if (movimientoVertical < 0f)
        {
            movimientoVertical = 0f; 
        }

        Vector3 movimiento = new Vector3(0f, movimientoVertical, movimientoHorizontal) * velocidad; 

        rigidbody.velocity = movimiento; 

        distanciaRecorrida = transform.position.y - posicionInicial.y;

        distanciaText.text = distanciaRecorrida.ToString();
    }
    public void RecibirBala()
    {
        perdio = true;
        SceneManager.LoadScene("Derrota");
    }

    public bool Perdio()
    {
        return perdio;
    }

    public float ObtenerDistanciaRecorrida()
    {
        return distanciaRecorrida;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            RecibirBala();
        }
    }
}
