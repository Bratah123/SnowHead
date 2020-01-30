using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D player;

    public float moveSpeed = 4f;
    public float bulletSpeed = 10f;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }
    }

    void FixedUpdate()
    {
        player.MovePosition(player.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
    void Shoot()
    {
        Debug.Log("Shoot!");
    }
}
