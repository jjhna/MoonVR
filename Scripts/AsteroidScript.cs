using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    private AsteroidButtonDown Assdown;
    private AsteroidButtonLeft Assleft;
    private AsteroidButtonUp Assup;
    private AsteroidButtonRight Assright;
    public int Asstrigger, Asspass;                 //Important to be used to trigger event, most likely seconds after it passes
    private FuelMeterlight2 Fuellight;
    public Rigidbody rb;
    private LevelTextAss lvlass;

    // Start is called before the first frame update
    void Start()
    {
        Asspass = 1;
        Asstrigger = 0;
        Assdown = FindObjectOfType<AsteroidButtonDown>();
        Assleft = FindObjectOfType<AsteroidButtonLeft>();
        Assup = FindObjectOfType<AsteroidButtonUp>();
        Assright = FindObjectOfType<AsteroidButtonRight>();
        Fuellight = FindObjectOfType<FuelMeterlight2>();
        rb = GetComponent<Rigidbody>();
        lvlass = FindObjectOfType<LevelTextAss>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Asstrigger == 1)
        {

            rb.drag = 3.5f;
            rb.useGravity = true;

            Assdown.interactable = true; 
            Assleft.interactable = true; 
            Assup.interactable = true; 
            Assright.interactable = true; 

            lvlass.AssLevel(1);

            if (Assdown.onoroff == true)
            {
                transform.Translate(0, 0, -1);
                Assdown.onoroff = false;
            }
            if (Assleft.onoroff == true)
            {
                transform.Translate(-1, 0, 0);
                Assleft.onoroff = false;
            }
            if (Assup.onoroff == true)
            {
                transform.Translate(0, 0, 1);
                Assup.onoroff = false;
            }
            if (Assright.onoroff == true)
            {
                transform.Translate(1, 0, 0);
                Assright.onoroff = false;
            }
        }
        else if(Asstrigger == 0)
        {
            inActive();
        }
        else
        {
            inActive();
            Fuellight.Fueldown();
            transform.gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            //Play game over scene'
            Asspass = 0;
        }
    }

    void inActive()
    {
        lvlass.AssLevel(0);
        rb.drag = 0;
        Assdown.interactable = false; 
        Assleft.interactable = false; 
        Assup.interactable = false; 
        Assright.interactable = false; 
        rb.useGravity = false;
    }
}
