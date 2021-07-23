using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelMeterlight2 : MonoBehaviour
{
    private float minLevel6, maxLevel6, midLevel6, danLevel6;
    private Vector3 obj2;
    private LevelTextFuel lvl3;
    // Start is called before the first frame update
    void Start()
    {
        minLevel6 = -0.5f;
        maxLevel6 = 0.5f;
        midLevel6 = -0.2f;
        //Set the level to max when game starts
        //Full fuel level
        transform.localPosition = new Vector3(0.5f, maxLevel6, 0);
        //Mid fuel level
        //transform.localPosition = new Vector3(0.5f, midLevel6, 0);
        //Low fuel level 
        //transform.localPosition = new Vector3(0.5f, minLevel6, 0);
        lvl3 = FindObjectOfType<LevelTextFuel>();
    }

    // Update is called once per frame
    void Update()
    {
        obj2 = transform.localPosition;
        if (obj2.y == midLevel6)
        {
            //Play alarm sound and player starts dying
            //Update mission control
            lvl3.NumLevel(0);
        }
        else if (obj2.y == minLevel6)
        {
            lvl3.NumLevel(0);
            //Game over
        }
        else if (obj2.y == maxLevel6)
        {
            //Update mission control
             lvl3.NumLevel(1);
        }
        else
        {
            lvl3.NumLevel(2);
        }
    }

    public void Fueldown()
    {
        transform.localPosition = new Vector3(0.5f, minLevel6, 0);
    }
}
