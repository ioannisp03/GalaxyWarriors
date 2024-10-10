using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenHitBoundary : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boundary"))
        {
            Destroy(gameObject); 
        }
    }
}
