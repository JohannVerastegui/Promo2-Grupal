using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float destructiontime;
    [SerializeField]
    private float timer;

    private Rigidbody rb;
    private GameObject enemy;
    private Vector3 originalDirection;

    void Start()
    {
        //timer = destructiontime;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void Awake()
    {
        //rb = GetComponent<Rigidbody>();
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);

        timer += Time.deltaTime;
        if (timer >= destructiontime)
        {
            Destroy(this.gameObject);
        }
    }

}
