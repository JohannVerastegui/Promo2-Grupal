using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoNivel2 : Personaje
{
    public GameObject balaPrefab;
    public Transform spawnPoint;
    public float velocidadBala = 5f;

    public void DispararBala()
    {
        GameObject bala = Instantiate(balaPrefab, spawnPoint.position, Quaternion.identity);
        bala.GetComponent<Rigidbody>().velocity = Vector3.left * velocidadBala;
    }
}
