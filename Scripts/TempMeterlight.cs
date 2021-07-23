using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempMeterlight : MonoBehaviour
{
    private float minLevel6, maxLevel6, midLevel6;
    private Vector3 obj10;
    private LevelTextTemp lvl6;
    private FreezeSound Freeze;
    private MainCameraScript Cam;

    // Start is called before the first frame update
    void Start()
    {
        minLevel6 = -0.5f;
        maxLevel6 = 0.5f;
        midLevel6 = 0f;
        //Set the level to max when game starts
        //transform.localPosition = new Vector3(0.5f, minLevel6, 0);
        transform.localPosition = new Vector3(0.5f, midLevel6, 0);
        //transform.localPosition = new Vector3(0.5f, maxLevel6, 0);
        lvl6 = FindObjectOfType<LevelTextTemp>();
        Freeze = FindObjectOfType<FreezeSound>();
        Cam = FindObjectOfType<MainCameraScript>();
    }

    // Update is called once per frame
    void Update()
    {
        obj10 = transform.localPosition;
        if (obj10.y == minLevel6)
        {
            //Update mission control
            lvl6.NumLevel(0);
        }
        else if (obj10.y == maxLevel6)
        {
            //Update mission control
            lvl6.NumLevel(2);
        }
        else if (obj10.y == midLevel6)
        {
            //Update mission control
            lvl6.NumLevel(1);
            //Everything is set to normal
        }
        else
        {
            lvl6.NumLevel(3);
        }
    }

    public void TempDown()
    {
        transform.localPosition = new Vector3(0.5f, minLevel6, 0);
        Freeze.freezesound.Play();
        Cam.frosty = true;
    }

    public void TempUp()
    {
        transform.localPosition = new Vector3(0.5f, maxLevel6, 0);
    }

    public void TempReg()
    {
        transform.localPosition = new Vector3(0.5f, midLevel6, 0);
        Freeze.freezesound.Pause();
        Cam.frosty = false;
    }
}
