using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoltageSound : MonoBehaviour
{
    public AudioSource powerSound3;

    // Start is called before the first frame update
    void Start()
    {
        powerSound3 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
