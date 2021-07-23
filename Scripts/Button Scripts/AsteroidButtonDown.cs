using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AsteroidButtonDown : MonoBehaviour
{
    AudioSource click;
    public bool interactable = true;
    public UnityEvent TriggerButton;
    public bool onoroff;

    // Start is called before the first frame update
    void Start()
    {
        onoroff = false; 
        click = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider _collider)
    {
        if (interactable == true && _collider.name == "Switch")
        { // If the button hit's the contact switch it has been pressed
            TriggerButton.Invoke();
            click.Play();
        }
    }

    public void TestOutput()
    {
        Debug.Log("button pressed!");
        onoroff = true;
    }
}
