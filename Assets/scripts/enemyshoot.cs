using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform firePoint1;
    public GameObject shooting;
    public float shootingInterval = 2f; 
    void Start()
    {
        InvokeRepeating("Shoot", 0f, shootingInterval); 
    }

    void Shoot()
    {
        Instantiate(shooting, firePoint1.position, firePoint1.rotation);
    }
}
