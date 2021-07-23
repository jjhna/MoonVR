using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionControlDoc : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> docs = new List<GameObject>();
    public int currentDoc = 0;
    // Start is called before the first frame update
    void Start()
    {
        docs[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to swap cameras, will be triggered when UI button is clicked
    public void SwapActiveDoc(int index)
    {
        docs[currentDoc].SetActive(false);
        docs[index].SetActive(true);
        currentDoc = index;
    }


}
