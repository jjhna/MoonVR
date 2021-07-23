using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTextFire : MonoBehaviour
{
    Text txt;
    private List<int> newNum = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        newNum.Add(0);
        newNum.Add(1);
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
            txt.text = "No Fire";
             GetComponent<Text>().color = Color.green;
        }
        else if (num == 1)
        {
             txt.text = "FIRE!!!";
             GetComponent<Text>().color = Color.red;
        }
        else
        {
            txt.text = "N/A";
            GetComponent<Text>().color = Color.white;
        }
    }
}
