using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private Transform bulletSpawnPoint;

    private Rigidbody rb;
    private GameObject enemy;
    private Vector3 originalDirection;

    [SerializeField]
    private float shootForce;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * horizontalInput * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

     void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
    private void Shoot()
    {
        /*GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.AddForce(bulletSpawnPoint.forward * shootForce, ForceMode.Impulse);
        */

        //originalDirection = rb.velocity = (enemy.transform.position - transform.position).normalized;
        //rb.velocity = (originalDirection * moveSpeed);

        Vector3 shootDirection = shootForce > 0 ? Vector3.right : Vector3.left;

        GameObject newBullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody>().velocity = shootDirection * 30;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}

