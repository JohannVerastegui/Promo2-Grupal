using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float bulletDuration = 10f;
    public float shootInterval = 2f;
    public Transform[] spawnPoints;

    private float lastShootTime;

    private void Update()
    {
        if (Time.time - lastShootTime >= shootInterval)
        {
            ShootBullet();
            lastShootTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.velocity = spawnPoint.forward * bulletSpeed;
            Destroy(bullet, bulletDuration);
        }
    }
}
