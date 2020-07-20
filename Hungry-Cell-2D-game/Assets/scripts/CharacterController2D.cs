using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D: MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = 10f;
    public float xmove, ymove = 0f;
    [SerializeField] private HealthBar _healthBar;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

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
            _healthBar.HealHealth(0.05f);
        }
    }
}
