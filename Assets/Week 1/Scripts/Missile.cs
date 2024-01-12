using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float speed = 5f;
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
}