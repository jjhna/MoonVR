using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionControlCameraDirector : MonoBehaviour
{
    [SerializeField]
    public List<Camera> cameras = new List<Camera>();
    public int currentCamera = 0;
    // Start is called before the first frame update
    void Start()
    {
        cameras[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function to swap cameras, will be triggered when UI button is clicked
    public void SwapActiveCamera(int index)
    {
        cameras[currentCamera].gameObject.SetActive(false);
        cameras[index].gameObject.SetActive(true);
        currentCamera = index;
    }


}
