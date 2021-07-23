using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviors : MonoBehaviour
{
    private MissionControlCameraDirector MCCameraDirector;
    private MissionControlData MCCdata;
    private MissionControlDoc MCCdoc;
    private MissionControlEmergency MCCeme;

    public Text ActiveCameraSubtitle;
    public Text ActiveDataSubtitle;
    public Text ActiveDocSubtitle;
    public Text ActiveEmeSubtitle;


    [SerializeField]
    private List<string> CameraTitles = new List<string>();
    [SerializeField]
    private List<string> DataTiles = new List<string>();
    [SerializeField]
    private List<string> DocTiles = new List<string>();
    [SerializeField]
    private List<string> EmeTiles = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        //find camera director in scene   
        MCCameraDirector = FindObjectOfType<MissionControlCameraDirector>();
        MCCdata = FindObjectOfType<MissionControlData>();
        MCCdoc = FindObjectOfType<MissionControlDoc>();
        MCCeme = FindObjectOfType<MissionControlEmergency>();
        //ActiveCameraSubtitle = GetComponent<Text>();
        CameraTitles.Add("Camera 01 (Overview Map)");
        CameraTitles.Add("Camera 02 (Life Support System)");
        CameraTitles.Add("Camera 03 (Main Ship Console)");
        CameraTitles.Add("Camera 04 (Spacecraft Control)");
        CameraTitles.Add("Camera 05 (Probe Station)");

        DataTiles.Add("Data 01 (Hypoxia)");
        DataTiles.Add("Data 02 (Decompression)");
        DataTiles.Add("Data 03 (Hyperthermia)");
        DataTiles.Add("Data 04 (Heart Arrhythmia)");
        DataTiles.Add("Data 05 (Social Isolation)");
        DataTiles.Add("Data 06 (SASW)");
        DataTiles.Add("Data 07 (Hypcapnia)");
        DataTiles.Add("Data 08 (Ebullism)");
        DataTiles.Add("Data 09 (Panic Attack)");
        DataTiles.Add("Data 10 (Hypercapnia)");

        DocTiles.Add("Doc 01 (Step 1)");
        DocTiles.Add("Doc 02 (Step 2)");
        DocTiles.Add("Doc 03 (Step 3)");
        DocTiles.Add("Doc 04 (Step 4)");
        DocTiles.Add("Doc 05 (Step 5)");
        DocTiles.Add("Doc 06 (Step 6)");
        DocTiles.Add("Doc 07 (Step 7)");
        DocTiles.Add("Doc 08 (Step 8)");
        DocTiles.Add("Doc 09 (Step 9)");

        EmeTiles.Add("Emergency 01 (Low Oxygen)");
        EmeTiles.Add("Emergency 02 (High Nitrogen)");
        EmeTiles.Add("Emergency 03 (Low Temperature)");
        EmeTiles.Add("Emergency 04 (Asteriod Event)");
        EmeTiles.Add("Emergency 05 (Communication Outage)");
        EmeTiles.Add("Emergency 06 (High Carbon Dioxide)");
        EmeTiles.Add("Emergency 07 (Power Outage)");
        EmeTiles.Add("Emergency 08 (Fire)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCameraButtonClick()
    {
        int cam = MCCameraDirector.currentCamera;
        if (cam >= 4)
        {
            MCCameraDirector.SwapActiveCamera(0);
            ActiveCameraSubtitle.text = CameraTitles[0];
        }
        else
        {
            cam++;
            MCCameraDirector.SwapActiveCamera(cam);
            ActiveCameraSubtitle.text = CameraTitles[cam];
        }
    }

    public void OnDataButtonClick()
    {
        int datanum = MCCdata.currentData;
        if (datanum >= 9)
        {
            MCCdata.SwapActiveData(0);
            ActiveDataSubtitle.text = DataTiles[0];
        }
        else
        {
            datanum++;
            MCCdata.SwapActiveData(datanum);
            ActiveDataSubtitle.text = DataTiles[datanum];
        }
    }

    public void OnDocButtonClick()
    {
        int docnum = MCCdoc.currentDoc;
        if (docnum >= 8)
        {
            MCCdoc.SwapActiveDoc(0);
            ActiveDocSubtitle.text = DocTiles[0];
        }
        else
        {
            docnum++;
            MCCdoc.SwapActiveDoc(docnum);
            ActiveDocSubtitle.text = DocTiles[docnum];
        }
    }

    public void OnEmeButtonClick()
    {
        int emenum = MCCeme.currentEme;
        if (emenum >= 7)
        {
            MCCeme.SwapActiveDoc(0);
            ActiveEmeSubtitle.text = EmeTiles[0];
        }
        else
        {
            emenum++;
            MCCeme.SwapActiveDoc(emenum);
            ActiveEmeSubtitle.text = EmeTiles[emenum];
        }
    }
}
