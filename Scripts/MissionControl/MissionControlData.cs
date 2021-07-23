using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionControlData : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> datas = new List<GameObject>();
    public int currentData = 0;
    // Start is called before the first frame update
    void Start()
    {
        datas[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to swap cameras, will be triggered when UI button is clicked
    public void SwapActiveData(int index)
    {
        datas[currentData].SetActive(false);
        datas[index].SetActive(true);
        currentData = index;
    }


}
