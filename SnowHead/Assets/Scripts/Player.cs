using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static int health = 100;

    public Image[] HpBar;

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

        HealthBarCalc();
    }

    void FixedUpdate()
    {
        player.MovePosition(player.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    
    void Shoot()
    {
        Debug.Log("Shoot!");
    }

    void HealthBarCalc()
    {
        if(Player.health <= 90)
        {
            HpBar[9].GetComponent<Image>().enabled = false;
        }
        else if(Player.health <= 80)
        {
            HpBar[8].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 70)
        {
            HpBar[7].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 60)
        {
            HpBar[6].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 50)
        {
            HpBar[5].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 40)
        {
            HpBar[4].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 30)
        {
            HpBar[3].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 20)
        {
            HpBar[2].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 10)
        {
            HpBar[1].GetComponent<Image>().enabled = false;
        }
        else if (Player.health <= 0)
        {
            HpBar[0].GetComponent<Image>().enabled = false;
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Dead");
    }
 }
