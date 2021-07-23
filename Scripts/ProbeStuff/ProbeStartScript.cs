using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeStartScript : MonoBehaviour
{
    private ProbeButtonScript probeButton;
    private GameObject spawnPoint, holostart;
    private Vector3 locationpoint, holopoint;

    // Start is called before the first frame update
    void Start()
    {
       // probeButton = FindObjectOfType<ProbeButtonScript>();
        spawnPoint = GameObject.Find("ProbeStartSpawn");
        locationpoint = spawnPoint.transform.position;
      //  holostart = GameObject.Find("probeholostart");
      //  holopoint = holostart.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (probeButton.probestart == true)
        {
            transform.position = locationpoint;
            probeButton.interactable = false;
        }
        else
        {
            transform.position = holopoint;
        }*/
    }

    public void startProbeBuild()
    {
        transform.position = locationpoint;
      //  probeButton.interactable = false;
    }
}
