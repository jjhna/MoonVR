using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitArrowmeterScript : MonoBehaviour
{
    //The min ammount the arrow can turn
    private float minPsi2, maxPsi2, midPsi2, danPsi2;
    private Vector3 obj3;
    private LevelTextNitrogen lvl4;
    private MainCameraScript Cam;
    public int Nitpass;

    // Start is called before the first frame update
    void Start()
    {
        Nitpass = 0;
        minPsi2 = 38f;
        maxPsi2 = 315f;
        midPsi2 = 180f;
        danPsi2 = 130f;
        //transform.localEulerAngles = new Vector3(90f, 200f, 0f);
        //Make the gas full
        //transform.localEulerAngles = new Vector3(90f, maxPsi2, 0f);
        //Puts the meter to the halfway point
        transform.localEulerAngles = new Vector3(90f, midPsi2, 0f);
        //Puts the meter to the danger zone
        //transform.localEulerAngles = new Vector3(90f, danPsi2, 0f);
        //Puts the meter to the end point
        //transform.localEulerAngles = new Vector3(90f, minPsi2, 0f);
        lvl4 = FindObjectOfType<LevelTextNitrogen>();
        Cam =FindObjectOfType<MainCameraScript>();
    }

    // Update is called once per frame
    void Update()
    {
        obj3 = transform.localEulerAngles;
        if (obj3.y == maxPsi2)
        {
            //Player gets Uremia symptoms 
            //Update mission control
            lvl4.NumLevel(2);
            Cam.unsync = true;
        }
        else if (obj3.y == midPsi2)
        {
            //Makes everything back to normal
            //Update mission control
            lvl4.NumLevel(1);
            Cam.unsync = false;
        }
        else if (obj3.y == danPsi2)
        {
            //Player gets infected with hyperoxia or oxygen toxicity
            //Update mission control
            lvl4.NumLevel(0);
            Cam.unsync = false;
        }
        else if (obj3.y == minPsi2)
        {
            //Play alarm sound and player starts dying
            //Update mission control
            lvl4.NumLevel(0);
            Cam.unsync = false;
        }
        else
        {
            //transform.localEulerAngles = new Vector3(90f, (obj4.y - 1f), 0f);
            lvl4.NumLevel(3);
            Cam.unsync = false;
        }
    }

    public void NitUp()
    {
        transform.localEulerAngles = new Vector3(90f, maxPsi2, 0f);
    }

    public void NitNew(int top)
    {
        if (top == 1)
        {
            transform.localEulerAngles = new Vector3(90f, midPsi2, 0f);
          //  Cam.unsync = false;
            Nitpass = 1;
        }
    }
}
