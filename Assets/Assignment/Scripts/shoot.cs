using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bubblePrefab;
    public Transform launcher;
    public Vector2 speed = new Vector2(10, 0);
    Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bubblePrefab, launcher.position, launcher.rotation);
        }
    }
    private void FixedUpdate()
    {
        bubblePrefab.GetComponent<Rigidbody2D>().MovePosition(rigidbody.position + speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bubblePrefab.SetActive(false);
    }
}