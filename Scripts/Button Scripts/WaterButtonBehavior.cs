using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaterButtonBehavior : MonoBehaviour
{
    AudioSource click3;
    public bool interactable = true;
    public UnityEvent TriggerButton;
    private FireExtinguishScript FireEx;
    private OxyArrowmeterScript OxyArr;
    private WaterArrowmeterScript WaterArr;
    private IEnumerator waiterOn;
    private FireSoundScript firenoise;
    public int Waterpass;

    // Start is called before the first frame update
    void Start()
    {
        FireEx = FindObjectOfType<FireExtinguishScript>();
        OxyArr = FindObjectOfType<OxyArrowmeterScript>();
        WaterArr = FindObjectOfType<WaterArrowmeterScript>();
        waiterOn = waiter();
        click3 = GetComponent<AudioSource>();
        firenoise = FindObjectOfType<FireSoundScript>();
        Waterpass = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider _collider)
    {
        //ok == true, only works when water is available and fire is on
        if (interactable == true && _collider.name == "Switch")
        { // If the button hit's the contact switch it has been pressed
            TriggerButton.Invoke();
            click3.Play();
            firenoise.watersound.Play();
            Waterpass = 1;
        }
    }

    public void TestOutput()
    {
        Debug.Log("water button pressed!");
        StartCoroutine(waiterOn);
    }

    IEnumerator waiter()
    {
        FireEx.TheTriggering1(true);            //Then turn on fire extinguisher
        //Wait for 5 seconds
        yield return new WaitForSeconds(5);
        FireEx.TheTriggering1(false);           //Then turn off fire extinguisher
        WaterArr.WaterDown();
        OxyArr.OxygenClear();
        StopCoroutine(waiterOn);
    }
}
