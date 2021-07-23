using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFireScript : MonoBehaviour
{
    private int triggerme1;
    private ParticleSystem theFire;
    // Start is called before the first frame update
    void Start()
    {
        theFire = GetComponent<ParticleSystem>();
        triggerme1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var emission1 = theFire.emission;
        if (triggerme1 == 0)
        {
            emission1.enabled = false;
            //theSmoke.Pause();
            //transform.gameObject.SetActive(false);
        }
        else
        {
            emission1.enabled = true;
            //theSmoke.Play();
            //transform.gameObject.SetActive(true);
        }
    }

    public void TheTriggering1(bool yesorno1)
    {
        if (yesorno1 == false)
        {
            triggerme1 = 0;
        }
        else
        {
            triggerme1 = 1;
        }
    }
}
