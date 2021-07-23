using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterArrowmeterScript : MonoBehaviour
{
    //The min ammount the arrow can turn
    private float minPsi9, maxPsi9, midPsi9, danPsi9; 
    private Vector3 obj5;
    private LevelTextWater lvl7;
    // Start is called before the first frame update
    void Start()
    {
        minPsi9 = 38f;
        danPsi9 = 130f;
        midPsi9 = 180f;
        maxPsi9 = 315f;
        //transform.localEulerAngles = new Vector3(90f, 200f, 0f);
        //Make the gas full
        transform.localEulerAngles = new Vector3(90f, maxPsi9, 0f);
        //Puts the meter to the halfway point
        //transform.localEulerAngles = new Vector3(90f, midPsi9, 0f);
        //Puts the meter to the danger zone
        //transform.localEulerAngles = new Vector3(90f, danPsi9, 0f);
        //Puts the meter to the end point
        //transform.localEulerAngles = new Vector3(90f, minPsi9, 0f);
        lvl7 = FindObjectOfType<LevelTextWater>();
    }

    // Update is called once per frame
    void Update()
    {
        obj5 = transform.localEulerAngles;
        if (obj5.y == maxPsi9)
        {
            //Update mission control
            lvl7.NumLevel(2);
        }
        else if (obj5.y == midPsi9)
        {
            //Update mission control
            lvl7.NumLevel(1);
        }
        else if (obj5.y == danPsi9)
        {
            //Update mission control
            lvl7.NumLevel(0);
        }
        else if (obj5.y == minPsi9)
        {
            lvl7.NumLevel(0);
            //Sprinklers and emergency water doesn't work
        }
        else
        {
            //transform.localEulerAngles = new Vector3(90f, (obj5.y - 1f), 0f);
            lvl7.NumLevel(3);
        }
    }

    public void WaterDown()
    {
        transform.localEulerAngles = new Vector3(90f, midPsi9, 0f);
    }

    public void WaterNew(int top)
    {
        if (top == 1)
        {
            transform.localEulerAngles = new Vector3(90f, maxPsi9, 0f);
        }
    }
}
