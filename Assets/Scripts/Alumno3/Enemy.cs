using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour, IObserver
{
    [SerializeField]
    private float lifeEnemy;

    [SerializeField]
    private float speed;

    private Rigidbody rb;

    public Transform player;
    private Vector3 playerPosition;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (player)
        {
            playerPosition = player.position;
            transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
            transform.LookAt(playerPosition);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            lifeEnemy -= 1f;
        }
        if (lifeEnemy <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Execute(ISubject subject)
    {
        if (subject is GameManager)
        {

        }
    }


}

