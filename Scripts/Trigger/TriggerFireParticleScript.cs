using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFireParticleScript : MonoBehaviour
{
    private int triggerme2;
    private ParticleSystem theFireParticle;
    // Start is called before the first frame update
    void Start()
    {
        theFireParticle = GetComponent<ParticleSystem>();
        triggerme2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var emission2 = theFireParticle.emission;
        if (triggerme2 == 0)
        {
            emission2.enabled = false;
            //theSmoke.Pause();
            //transform.gameObject.SetActive(false);
        }
        else
        {
            emission2.enabled = true;
            //theSmoke.Play();
            //transform.gameObject.SetActive(true);
        }
    }

    public void TheTriggering2(bool yesorno2)
    {
        if (yesorno2 == false)
        {
            triggerme2 = 0;
        }
        else
        {
            triggerme2 = 1;
        }
    }
}
