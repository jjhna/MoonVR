using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSmokeScript : MonoBehaviour
{
    private int triggerme;
    private ParticleSystem theSmoke;
    // Start is called before the first frame update
    void Start()
    {
        theSmoke = GetComponent<ParticleSystem>();
        triggerme = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var emission = theSmoke.emission;
        if (triggerme == 0)
        {
            emission.enabled = false;
            //theSmoke.Pause();
            //transform.gameObject.SetActive(false);
        }
        else
        {
            emission.enabled = true;
            //theSmoke.Play();
            //transform.gameObject.SetActive(true);
        }
    }

    public void TheTriggering(bool yesorno)
    {
        if (yesorno == false)
        {
            triggerme = 0;
        }
        else
        {
            triggerme = 1;
        }
    }
}
