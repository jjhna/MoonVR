using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EMUScript : MonoBehaviour
{
    public float movEMU, rotEMU;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves our little astronaut outside 
        transform.Translate(+movEMU, 0, 0);
        //Rotates our little astronaut
        transform.Rotate(+rotEMU, +rotEMU, +rotEMU);
    }
}
