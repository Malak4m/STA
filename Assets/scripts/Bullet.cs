using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Enemy"))
        {
            enemy enemy = hitInfo.GetComponent<enemy>();
            
            if (enemy != null)
            {
                enemy.TakeDamage();
                Destroy(gameObject);
            }
        }
    }
}
