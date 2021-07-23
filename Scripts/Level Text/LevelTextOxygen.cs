using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelTextOxygen : MonoBehaviour
{
    Text txt;
    private List<int> newNum = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        newNum.Add(0);
        newNum.Add(1);
        newNum.Add(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        //Sets the level and color of text
    public void NumLevel(int num)
    {
        if (num == 0)
        {
            txt.text = "Low";
             GetComponent<Text>().color = Color.red;
        }
        else if (num == 1)
        {
             txt.text = "Normal";
             GetComponent<Text>().color = Color.green;
        }
        else if (num == 2)
        {
             txt.text = "High";
             GetComponent<Text>().color = Color.red;
        }
        else
        {
            txt.text = "N/A";
            GetComponent<Text>().color = Color.white;
        }
    }
}
