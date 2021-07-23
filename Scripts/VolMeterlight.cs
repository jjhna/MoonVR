using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolMeterlight : MonoBehaviour
{
    public GameObject Alien;
    private float minLevel5, maxLevel5, midLevel5;
    private Vector3 obj6;
    private GameObject[] allLights;
    public bool isAlien;
    private LevelTextVol lvl1;
    private VoltageButtonBehavior Vol1;
    private IEnumerator waiterOn;
    private GameObject Alienclone;
    private PowerOutScript Power;
    private PowerUpScript Power2;
    public GameObject console_screen;


    // Start is called before the first frame update
    void Start()
    {
        waiterOn = waiter();
        isAlien = false;
        minLevel5 = -0.5f;
        maxLevel5 = 0.5f;
        midLevel5 = 0f;
        //Set the level to max when game starts
        //Full battery level
        transform.localPosition = new Vector3(0.5f, maxLevel5, 0);
        //Mid battery level
        //transform.localPosition = new Vector3(0.5f, midLevel5, 0);
        //Low battery level 
        //transform.localPosition = new Vector3(0.5f, minLevel5, 0);
        allLights = GameObject.FindGameObjectsWithTag("LightTag");
        lvl1 = FindObjectOfType<LevelTextVol>();
        Vol1 = FindObjectOfType<VoltageButtonBehavior>();
        Power = FindObjectOfType<PowerOutScript>();
        Power2 = FindObjectOfType<PowerUpScript>();
    }

    // Update is called once per frame
    void Update()
    {
        obj6 = transform.localPosition;
        if (obj6.y == minLevel5)
        {
            //Turns off all the lights in the room
            foreach(GameObject lights in allLights)
            {
                lights.SetActive(false);
            }
            console_screen.SetActive(false);
            //Triger Alien event
            if (isAlien == false)
            {
                StartCoroutine(waiterOn);
                isAlien = true;
            }
            //Update mission control
            lvl1.NumLevel(0);
            //Press button to reboot and add charge
            Vol1.interactable = true; 
            if (Vol1.onoroff == true)
            {
                //Turns power back to full
                transform.localPosition = new Vector3(0.5f, maxLevel5, 0);
                Power2.powerSound2.Play();
            }
        }
        else if (obj6.y == midLevel5)
        {
            Turnonlights();
            //Update mission control
            lvl1.NumLevel(2);
        }
        else if (obj6.y == maxLevel5)
        {
            Turnonlights();
            //Update mission control
            lvl1.NumLevel(1);
        }
        else
        {
            Turnonlights();
            lvl1.NumLevel(2);
        }
    }

    //Function to turn on all the lights and turn off alarm
    void Turnonlights()
    {
        //Keep all the lights on
             foreach(GameObject lights in allLights)
            {
                lights.SetActive(true);
            }
            isAlien = true;        //Turn off alien
            Vol1.interactable = false;  //Turns off power button switch
            Vol1.onoroff = false;
            console_screen.SetActive(true);
    }

    IEnumerator waiter()
    {
        //Wait for 10 seconds
        yield return new WaitForSeconds(10);
        //Spawn alien after certain amount of seconds
        Alienclone = Instantiate(Alien, new Vector3(7, 4, -14), Quaternion.identity);
        //Wait for 11 seconds
        yield return new WaitForSeconds(11);
        //Destroy alien
        DestroyImmediate(Alienclone);
        StopCoroutine(waiterOn);
    }

    public void VolDown()
    {
        transform.localPosition = new Vector3(0.5f, minLevel5, 0);
        Power.powerSound.Play();
    }

    public void VolMid()
    {
        transform.localPosition = new Vector3(0.5f, midLevel5, 0);
    }
}
