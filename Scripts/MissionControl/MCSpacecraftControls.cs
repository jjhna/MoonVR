using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MCSpacecraftControls : MonoBehaviour
{

    public GameObject rooflights;
    public Text lightbuttontext;
    public Text gravbuttontext;
    public GameObject lightbuttoncolor;
    public GameObject gravbuttoncolor;

    bool gravityOn;

    // Start is called before the first frame update
    void Start()
    {
        gravityOn = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleRoofLights()
    {
        if (rooflights.activeSelf)
        {
            rooflights.SetActive(false);
            lightbuttoncolor.GetComponent<Image>().color = Color.green;   
            lightbuttontext.text = "Turn on\nSpacecraft Lights";
        }
        else
        {
            rooflights.SetActive(true);
            lightbuttoncolor.GetComponent<Image>().color = Color.red;
            lightbuttontext.text = "Turn off\nSpacecraft Lights";
        }

    }

    public void ToggleGravity()
    {
        if (gravityOn)
        {
            gravityOn = false;
            gravbuttoncolor.GetComponent<Image>().color = Color.green;
            gravbuttontext.text = "Turn on\nSpacecraft Gravity";
        }
        else
        {
            gravityOn = true;
            gravbuttoncolor.GetComponent<Image>().color = Color.red;
            gravbuttontext.text = "Turn off\nSpacecraft Gravity";
        }
     

        GameObject[] items = GameObject.FindGameObjectsWithTag("gravityItem");
        
        foreach(GameObject item in items)
        {
           // Debug.Log(item.name);
            item.GetComponent<Rigidbody>().useGravity = gravityOn;
        }

        GameObject[]  probeitems = GameObject.FindGameObjectsWithTag("ProbeTag");

        foreach (GameObject item in probeitems)
        {
            // Debug.Log(item.name);
            item.GetComponent<Rigidbody>().useGravity = gravityOn;
        }

        if(GameObject.Find("WaterTank") != null) GameObject.Find("WaterTank").GetComponent<Rigidbody>().useGravity = gravityOn;
        if (GameObject.Find("OxygenTank") != null) GameObject.Find("OxygenTank").GetComponent<Rigidbody>().useGravity = gravityOn;
        if (GameObject.Find("NitrogenTank") != null) GameObject.Find("NitrogenTank").GetComponent<Rigidbody>().useGravity = gravityOn;
        if (GameObject.Find("AirFilter2") != null) GameObject.Find("AirFilter2").GetComponent<Rigidbody>().useGravity = gravityOn;
    }

}
