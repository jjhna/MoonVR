using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFireSmokeScript : MonoBehaviour
{
    private int triggerme3;
    private ParticleSystem theFireSmoke;
    // Start is called before the first frame update
    void Start()
    {
        theFireSmoke = GetComponent<ParticleSystem>();
        triggerme3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var emission3 = theFireSmoke.emission;
        if (triggerme3 == 0)
        {
            emission3.enabled = false;
            //theSmoke.Pause();
            //transform.gameObject.SetActive(false);
        }
        else
        {
            emission3.enabled = true;
            //theSmoke.Play();
            //transform.gameObject.SetActive(true);
        }
    }

    public void TheTriggering3(bool yesorno3)
    {
        if (yesorno3 == false)
        {
            triggerme3 = 0;
        }
        else
        {
            triggerme3 = 1;
        }
    }
}
