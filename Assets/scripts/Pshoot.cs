
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pshoot : MonoBehaviour
{
    public Transform firepoint;
    public GameObject shooting;

   
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(shooting, firepoint.position, firepoint.rotation);
    }
}
