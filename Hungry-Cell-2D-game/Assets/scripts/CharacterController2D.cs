using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D: MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = 10f;
    public float xmove, ymove = 0f;
    [SerializeField] public HealthBar _healthBar;
    
    
    void Start() { rb2d = GetComponent<Rigidbody2D>();}
    
    private void FixedUpdate()
    {
        xmove = Input.GetAxisRaw("Horizontal")* speed;
        ymove = Input.GetAxisRaw("Vertical") * speed;
        Vector2 movement = new Vector2(xmove,ymove);
        rb2d.AddForce(movement);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            
            Destroy(other.gameObject);
            Score.scoreAmount += 1;
            
            FindObjectOfType<AudioManager>().Play("CollectFood");
            
            _healthBar.HealHealth(0.05f);
        }
    }
    
}
