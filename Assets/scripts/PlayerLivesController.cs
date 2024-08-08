using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesController : MonoBehaviour
{
    public int Lives = 3;
    public Image[] LivesUI;
    public GameObject explosionPrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("Enemy");

            Destroy(collision.collider.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Lives -= 1;
            for (int i = 0; i < LivesUI.Length; i++)
            {
                if (i < Lives)
                {
                    LivesUI[i].enabled = true;
                }
                else
                {
                    LivesUI[i].enabled = false;
                }
            }
            if (Lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}