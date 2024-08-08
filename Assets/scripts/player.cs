using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    [SerializeField] float moveSpeed;
    [SerializeField] Animator playerr;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}


