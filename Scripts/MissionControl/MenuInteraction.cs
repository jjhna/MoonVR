using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInteraction : MonoBehaviour
{

    public GameObject StatsPage;
    public GameObject CamsPage;
    public GameObject DocsPage;
    public GameObject EmePage;
    public GameObject DataPage;
    public GameObject CtrlPage;

    GameObject currpage;

    // Start is called before the first frame update
    void Start()
    {
        currpage = StatsPage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeView(string page)
    {
        currpage.gameObject.SetActive(false);

        switch (page)
        {
            case "stats":
                StatsPage.gameObject.SetActive(true);
                currpage = StatsPage;
                break;
            case "cams":
                CamsPage.gameObject.SetActive(true);
                currpage = CamsPage;
                break;
            case "docs":
                DocsPage.gameObject.SetActive(true);
                currpage = DocsPage;
                break;
            case "eme":
                EmePage.gameObject.SetActive(true);
                currpage = EmePage;
                break;
            case "data":
                DataPage.gameObject.SetActive(true);
                currpage = DataPage;
                break;
            case "ctrl":
                CtrlPage.gameObject.SetActive(true);
                currpage = CtrlPage;
                break;
        }

        
    }
}
