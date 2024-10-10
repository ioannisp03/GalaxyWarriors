using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speed = 10.0f;
    private Rigidbody2D playerShipRB;

    void Start()
    {
        playerShipRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerShipRB.MovePosition(playerShipRB.position + Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerShipRB.MovePosition(playerShipRB.position + Vector2.right * speed * Time.deltaTime);
        }
    }
}
