using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VoltageButtonBehavior : MonoBehaviour
{
    AudioSource click2;
    public bool interactable = true;
    public UnityEvent TriggerButton;
    public bool onoroff;
    public int Volpass;

    // Start is called before the first frame update
    void Start()
    {
        Volpass = 0;
        onoroff = false;
        interactable = true;
        click2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider _collider)
    {
        //ok == true, only works when power is down
        if (interactable == true && _collider.name == "Switch")
        { // If the button hit's the contact switch it has been pressed
            TriggerButton.Invoke();
            click2.Play();
            Volpass = 1;
        }
    }

    public void TestOutput()
    {
        Debug.Log("voltage button pressed!");
        onoroff = true;
    }
}
