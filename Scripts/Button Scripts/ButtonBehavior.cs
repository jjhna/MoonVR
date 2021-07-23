using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonBehavior : MonoBehaviour
{

    public bool interactable = true;
    public UnityEvent TriggerButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider _collider)
    {
     //   Debug.Log(_collider.name);

        if (interactable == true && _collider.name == "Switch")
        { // If the button hit's the contact switch it has been pressed
            Debug.Log("button pressed!");
            TriggerButton.Invoke();
        }
    }

    public void TestOutput()
    {
        Debug.Log("button pressed!");
    }
}
