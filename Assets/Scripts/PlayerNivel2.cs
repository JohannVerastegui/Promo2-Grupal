using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNivel2 : Personaje
{
    private bool perdio;
    private float distanciaRecorrida;
    public new Rigidbody rigidbody;
    public float velocidad = 2;
    private Vector3 posicionInicial;



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

        Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0f ) * velocidad; 

        rigidbody.velocity = movimiento; 

        distanciaRecorrida = transform.position.z - posicionInicial.z; 
    }
    public void RecibirBala()
    {
        perdio = true;
    }

    public bool Perdio()
    {
        return perdio;
    }

    public float ObtenerDistanciaRecorrida()
    {
        return distanciaRecorrida;
    }
}
