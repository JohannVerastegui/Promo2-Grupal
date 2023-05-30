using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.CompareTag("Player"))
            {
                FindObjectOfType<LevelController>().LoadLevel("Death");
            }
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        Level3Manager.instance.bulletsLeft -= 1;
        Level3Manager.instance.UpdateBulletText();
    }
}
