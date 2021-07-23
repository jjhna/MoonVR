using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAlarmScript : MonoBehaviour
{
    public AudioSource assalarm;
    IEnumerator waiterOn;

    // Start is called before the first frame update
    void Start()
    {
        assalarm = GetComponent<AudioSource>();
        waiterOn = waiter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            assalarm.Play();
            yield return new WaitForSeconds(4);
            assalarm.Pause();
        }
    }

    public void CourtStart()
    {
        StartCoroutine(waiterOn);
    }

    public void CourtStop()
    {
        StopCoroutine(waiterOn);
    }
}
