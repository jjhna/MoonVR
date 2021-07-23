using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExtinguishScript : MonoBehaviour
{
    private int triggerme1;
    private ParticleSystem theSmoke1;
    // Start is called before the first frame update
    void Start()
    {
        theSmoke1 = GetComponent<ParticleSystem>();
        triggerme1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var emission1 = theSmoke1.emission;
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
    
    public void TheTriggering1(bool yesorno)
    {
        if (yesorno == false)
        {
            triggerme1 = 0;
        }
        else
        {
            triggerme1 = 1;
        }
    }
}
