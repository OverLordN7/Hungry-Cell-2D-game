using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //responsible for movement
    private Rigidbody2D rb2d;
    public float speed = 10f;
    public float xmove, ymove = 0f;
    
    
    //responsible for joystick control
    [SerializeField] private Joystick joystick;
    private float angleOffset = 90f;
    public float adaptiveSpeed = 20f;
    
    void Start() { rb2d = GetComponent<Rigidbody2D>();}

    private void FixedUpdate()
    {
        xmove = Input.GetAxisRaw("Horizontal")* speed;
        ymove = Input.GetAxisRaw("Vertical") * speed;
        Vector2 movement = new Vector2(xmove,ymove);
        rb2d.AddForce(movement);
    }
    
    
    private void Update()
    {
        if (joystick.speed > 0.0f)
        {
            
            Vector2 direction = joystick.direction;
            float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
            transform.rotation = quaternion.Euler(0.0f,0.0f,angle+ angleOffset);
            transform.Translate(direction * (adaptiveSpeed * joystick.speed * Time.deltaTime),Space.World);
            
            
        }
    }
    
    
   
}
