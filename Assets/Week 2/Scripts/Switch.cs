using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public Color mycolor;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
     spriteRenderer = GetComponent<SpriteRenderer>();
       spriteRenderer.color = mycolor;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger form: " + collision.gameObject);
        spriteRenderer.color = Color.red;
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = mycolor;
    }
    // Update is called once per frame
    void Update()
    {
    }
}