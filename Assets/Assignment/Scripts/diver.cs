using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diver : MonoBehaviour
{
    Vector2 direction;
    public float speed = 5f;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
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
        rigidbody.MovePosition(rigidbody.position + direction * speed * Time.deltaTime);
    }
}
