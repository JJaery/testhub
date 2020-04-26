using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float stamina = 1.0f;
    
    void Update()
    {
        Move();        
    }

    public void Move()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        Vector3 Pos = transform.position;
        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0.0f)
        {
            Pos.x = transform.position.x + Horizontal * 2.5f * moveSpeed;
            Pos.y = transform.position.y + Vertical * 2.5f * moveSpeed;

            stamina -= Time.deltaTime;
        }
        else
        {
            Pos.x = transform.position.x + Horizontal * moveSpeed;
            Pos.y = transform.position.y + Vertical * moveSpeed;
        }

        if (!Input.GetKey(KeyCode.LeftShift) && stamina < 3.0f)
        {
            stamina += Time.deltaTime;
        }
        if (stamina > 3.0f)
            stamina = 3.0f;
        transform.position = Pos;
    }  
}
