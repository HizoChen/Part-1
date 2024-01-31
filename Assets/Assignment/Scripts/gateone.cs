using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bubble"))
        {
            Debug.Log("Trigger form: " + collision.gameObject);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
