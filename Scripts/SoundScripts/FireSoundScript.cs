using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSoundScript : MonoBehaviour
{
    public AudioSource watersound;

    // Start is called before the first frame update
    void Start()
    {
        watersound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
