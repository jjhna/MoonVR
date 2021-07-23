using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionControlEmergency : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> emes = new List<GameObject>();
    public int currentEme = 0;
    // Start is called before the first frame update
    void Start()
    {
        emes[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to swap cameras, will be triggered when UI button is clicked
    public void SwapActiveDoc(int index)
    {
        emes[currentEme].SetActive(false);
        emes[index].SetActive(true);
        currentEme = index;
    }


}
