using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOutScript : MonoBehaviour
{
    public AudioSource powerSound;

    // Start is called before the first frame update
    void Start()
    {
        powerSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
