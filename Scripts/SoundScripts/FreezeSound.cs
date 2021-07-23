using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeSound : MonoBehaviour
{
    public AudioSource freezesound;

    // Start is called before the first frame update
    void Start()
    {
        freezesound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
