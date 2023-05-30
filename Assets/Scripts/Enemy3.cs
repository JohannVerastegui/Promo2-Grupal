using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    Transform playerTransform;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float shootIntervalMin, shootIntervalMax;
    [SerializeField] float bulletDisappear = 10f;

    private float timer = 0f;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        timer = Random.Range(shootIntervalMin, shootIntervalMax);
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            if (Level3Manager.instance.bulletsLeft > 0)
            {
                Shoot();
                timer = Random.Range(shootIntervalMin, shootIntervalMax);
            }
        }
    }

    public void Shoot()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        Quaternion rotation = Quaternion.LookRotation(direction);
        var bullet = Instantiate(bulletPrefab, firePoint.position, rotation);
        bullet.GetComponent<Rigidbody>().AddForce(direction * bulletSpeed, ForceMode.Impulse);
        Destroy(bullet.gameObject, bulletDisappear);
    }
}
