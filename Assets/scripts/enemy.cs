using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour

{

    private PiontManger PointManager;
    public float speed = 1f;
    void Start()
    {
        PointManager = GameObject.Find("PiontManager").GetComponent<PiontManger>();
    }
        // Update is called once per frame
        void Update()
    {
        
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    public void TakeDamage()
    {

        PointManager.UpdateScore(1);
        Destroy(gameObject);
       
    }

   

}
