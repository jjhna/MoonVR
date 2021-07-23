using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ProbeButtonScript : MonoBehaviour
{
    AudioSource click;
    public bool interactable = true;
    public bool probestart;
    public UnityEvent TriggerButton;
    private IEnumerator waiterlazer;
    private GameObject Lazerobject;
    public GameObject Lazerorigin;
    private TriggerSmokeProbe TProbe;



    // Start is called before the first frame update
    void Start()
    {
        probestart = false;
        waiterlazer = waiter();
        click = GetComponent<AudioSource>();
        TProbe = GetComponent<TriggerSmokeProbe>();
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
            TestOutput();
        }
    }

    public void TestOutput()
    {
        Debug.Log("probe button pressed!");
        probestart = true;
        interactable = false;
        StartCoroutine(waiterlazer);
    }

    IEnumerator waiter()
    {
        //Spawn lazer
        Lazerobject = Instantiate(Lazerorigin);
        TProbe.TheTriggeringProbe(true);    //Turn smoke on
        //Wait for 10 seconds
        yield return new WaitForSeconds(10);
        //Destroy lazer
        TProbe.TheTriggeringProbe(false);   //Turn smoke off
        DestroyImmediate(Lazerobject);
        StopCoroutine(waiterlazer);
    }
}
