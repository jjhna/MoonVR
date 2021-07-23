using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbeRespawnScript : MonoBehaviour
{
    GameObject RespawnPoint;
    Vector3 RespawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        RespawnPoint = GameObject.Find("ProbeRespawnArea");
        RespawnLocation = RespawnPoint.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="ProbeTag")
        {
            transform.localPosition = RespawnLocation;
        }
    }
}
