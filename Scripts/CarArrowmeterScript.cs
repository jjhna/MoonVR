using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarArrowmeterScript : MonoBehaviour
{
    //The min ammount the arrow can turn
    private float minPsi3, maxPsi3, midPsi3;
    private Vector3 obj1;
    private TriggerSmokeScript Smoke1;
    private LevelTextCarbon lvl2;
    private MainCameraScript Cam;
    public int Carpass;

    // Start is called before the first frame update
    void Start()
    {
        Carpass = 0;
        minPsi3 = 38f;
        midPsi3 = 180f;
        maxPsi3 = 315f;
        //transform.localEulerAngles = new Vector3(90f, midPsi3, 0f);
        transform.localEulerAngles = new Vector3(90f, minPsi3, 0f);
        //transform.localEulerAngles = new Vector3(90f, maxPsi3, 0f);
        Smoke1 = FindObjectOfType<TriggerSmokeScript>();
        lvl2 = FindObjectOfType<LevelTextCarbon>();
        Cam = FindObjectOfType<MainCameraScript>();
    }

    // Update is called once per frame
    void Update()
    {
        obj1 = transform.localEulerAngles;
        if (obj1.y == maxPsi3)
        {

            //Smoke plays out until new filter is installed
            Smoke1.TheTriggering(true);
            //Update mission control
            lvl2.NumLevel(2);
            Cam.tint = true;
        }
        else if (obj1.y == midPsi3)
        {
            SmokeTriger();
            //Update mission control
            lvl2.NumLevel(1);
        }
        else if (obj1.y == minPsi3)
        {
            SmokeTriger();
            //Update mission control
            lvl2.NumLevel(0);
        }
        else
        {
            SmokeTriger();
            //Update mission control
            lvl2.NumLevel(3);
        }
    }

    //Redcue repeating 
    void SmokeTriger()
    {
        Smoke1.TheTriggering(false);
        Cam.tint = false;
    }

    public void StartTriggering()
    {
        transform.localEulerAngles = new Vector3(90f, maxPsi3, 0f);
    }

    public void CarDown(int top)
    {
        if (top == 1)
        {
            transform.localEulerAngles = new Vector3(90f, minPsi3, 0f);
            Carpass = 1;
        }
    }
}
