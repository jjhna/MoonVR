using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeDisplayScript : MonoBehaviour
{
    public bool probeOn;
    private GameObject spawnPoint, startPoint;
    private Vector3 locationpoint, orglocation;

    // Start is called before the first frame update
    void Start()
    {
        probeOn = false;
        spawnPoint = GameObject.Find("ProbeHoloSpawn");
        locationpoint = spawnPoint.transform.position;
        startPoint = GameObject.Find("probeholostart");
        orglocation = startPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (probeOn == true)
        {
            transform.position = locationpoint;
        }
        else
        {
            transform.position = orglocation;
        }
    }
}
