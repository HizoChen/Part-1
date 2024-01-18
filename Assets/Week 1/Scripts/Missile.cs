using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public Vector2 speed = new Vector2(10,0);
    Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + speed * Time.deltaTime);   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
