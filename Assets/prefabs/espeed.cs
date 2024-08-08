using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espeed : MonoBehaviour
{
    public float speeds = 20f;
    public Rigidbody2D rb1;

    // Start is called before the first frame update
    void Start()
    {
        rb1.velocity = -transform.up * speeds;
    }
}