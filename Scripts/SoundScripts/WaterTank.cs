using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTank : MonoBehaviour
{
    AudioSource Audiomasta3;

    // Start is called before the first frame update
    void Start()
    {
        Audiomasta3 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Any item that collides with the floor  will make it respawn back to the spawn point
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "FloorTag")
        {
            Audiomasta3.Play();
        }
    }
}
