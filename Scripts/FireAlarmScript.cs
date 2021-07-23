using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAlarmScript : MonoBehaviour
{
    public AudioSource assalarm2;
    IEnumerator waiterOn;

    // Start is called before the first frame update
    void Start()
    {
        assalarm2 = GetComponent<AudioSource>();
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
            assalarm2.Play();
            yield return new WaitForSeconds(4);
            assalarm2.Pause();
        }
    }

    public void CourtStart2()
    {
        StartCoroutine(waiterOn);
    }

    public void CourtStop2()
    {
        StopCoroutine(waiterOn);
    }
}
