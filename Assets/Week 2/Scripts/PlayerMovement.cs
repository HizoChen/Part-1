using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 direction;
    public float force = 150f;
    public Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player hit something");
    }
}
