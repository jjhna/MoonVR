using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRespawnTankScript : MonoBehaviour
{
    public GameObject respawnobj;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Any item that collides with the quad will make it respawn back to the spawn point
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WaterTag")
        {

            GameObject water = collision.gameObject;
            water.transform.localPosition = respawnobj.transform.localPosition;
        }
        if (collision.gameObject.tag == "OxyTank")
        {
            GameObject oxygen = collision.gameObject;
            oxygen.transform.localPosition = respawnobj.transform.localPosition;
        }
        if (collision.gameObject.tag == "NitTank")
        {
            GameObject nitrogen = collision.gameObject;
            nitrogen.transform.localPosition = respawnobj.transform.localPosition;
        }
        if (collision.gameObject.tag == "FilterTag")
        {
            GameObject filter = collision.gameObject;
            filter.transform.localPosition = respawnobj.transform.localPosition;
        }
    }
}
