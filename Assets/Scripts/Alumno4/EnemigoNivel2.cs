using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoNivel2 : Personaje
{
    public GameObject enemigo;
    public GameObject bullet;
    public Transform spawnPoint;
    public float velocidadBala = 5f;
    public float intervalo = 3f;
    public float timer = 0f;
    void Start()
    {
        Aparecer();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervalo)
        {
            Aparecer();
            timer = 0f;
        }

    }

    private void Aparecer()
    {
        enemigo.transform.position = spawnPoint.position;
        DispararBala();
    }
    public void DispararBala()
    {
        GameObject bala = Instantiate(bullet, spawnPoint.position, Quaternion.identity);
        bala.GetComponent<Rigidbody>().velocity = Vector3.left * velocidadBala;
    }
}
