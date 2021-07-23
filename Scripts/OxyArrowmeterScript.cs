using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxyArrowmeterScript : MonoBehaviour
{
    //The min ammount the arrow can turn
    private float minPsi8, maxPsi8, midPsi8, danPsi8; 
    private Vector3 obj4;
    private TriggerFireScript Fire1;
    private TriggerFireSmokeScript Smoke2;
    private TriggerFireParticleScript FireParticle1;
    private LevelTextOxygen lvl5;
    private WaterButtonBehavior WaterB1;
    private TempMeterlight Templight1;
    private MainCameraScript Cam;
    private LevelTextFire lvlfire;
    public int Oxypass;

    // Start is called before the first frame update
    void Start()
    {
        Oxypass = 0;
        minPsi8 = 38f;
        maxPsi8 = 315f;
        midPsi8 = 180f;
        danPsi8 = 130f;
        //transform.localEulerAngles = new Vector3(90f, 200f, 0f);
        //Make the gas full
        //transform.localEulerAngles = new Vector3(90f, maxPsi8, 0f);
        //Puts the meter to the halfway point
        transform.localEulerAngles = new Vector3(90f, midPsi8, 0f);
        //Puts the meter to the danger zone
        //transform.localEulerAngles = new Vector3(90f, danPsi8, 0f);
        //Puts the meter to the end point
        //transform.localEulerAngles = new Vector3(90f, minPsi8, 0f);
        Fire1 = FindObjectOfType<TriggerFireScript>();
        Smoke2 = FindObjectOfType<TriggerFireSmokeScript>();
        FireParticle1 = FindObjectOfType<TriggerFireParticleScript>();
        lvl5 = FindObjectOfType<LevelTextOxygen>();
        WaterB1 = FindObjectOfType<WaterButtonBehavior>();
        Templight1 = FindObjectOfType<TempMeterlight>();
        Cam = FindObjectOfType<MainCameraScript>();
        lvlfire = FindObjectOfType<LevelTextFire>();
    }

    // Update is called once per frame
    void Update()
    {
        obj4 = transform.localEulerAngles;
        if (obj4.y == maxPsi8)
        {
            //Sends trigger that oxygen is full and likely to cause fire
            StartTriggering();
            //Update mission control
            lvlfire.NumLevel(1);
            lvl5.NumLevel(2);
            Cam.vram = false;
            Cam.bleed = false;
        }
        else if (obj4.y == midPsi8)
        {
            //Makes everything back to normal
            StopTriggering();
            //Update mission control
            lvl5.NumLevel(1);
            lvlfire.NumLevel(0);
        }
        else if (obj4.y == danPsi8)
        {
            //Player suffers from hypoxia 
            //Update mission control
            lvl5.NumLevel(0);
            StopTriggering();
        }
        else if (obj4.y == minPsi8)
        {
            //Player suffers from hypoxia 
            lvl5.NumLevel(0);
            Cam.vram = true;
            Cam.bleed = true;
        }
        else
        {
            //transform.localEulerAngles = new Vector3(90f, (obj4.y - 1f), 0f);
            StopTriggering();
            lvl5.NumLevel(3);
        }
    }

    //Stops Triggering the particle effects
    void StopTriggering()
    {
        Fire1.TheTriggering1(false);
        FireParticle1.TheTriggering2(false);
        Smoke2.TheTriggering3(false);
        WaterB1.interactable = false;
        Cam.vram = false;
        Cam.bleed = false;
    }

    //Starts Triggering the particle effects
    void StartTriggering()
    {
        Fire1.TheTriggering1(true);
        FireParticle1.TheTriggering2(true);
        Smoke2.TheTriggering3(true);
        WaterB1.interactable = true;
        Templight1.TempUp();
    }

    public void OxygenClear()
    {
        transform.localEulerAngles = new Vector3(90f, midPsi8, 0f);
    }

    public void OxygenUp()
    {
        transform.localEulerAngles = new Vector3(90f, maxPsi8, 0f);
    }

    public void OxygenDown()
    {
        transform.localEulerAngles = new Vector3(90f, minPsi8, 0f);
    }

    public void OxygenDan()
    {
        transform.localEulerAngles = new Vector3(90f, danPsi8, 0f);
    }

    public void OxygenNew(int top)
    {
        if (top == 1)
        {
            OxygenClear();
            Oxypass = 1;
        }
    }
}
