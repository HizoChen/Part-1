using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject Missileprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Missileprefab, spawnpoint.position, spawnpoint.rotation);
    }
}
