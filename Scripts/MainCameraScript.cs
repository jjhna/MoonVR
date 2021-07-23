using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public bool frosty;
    public bool tint;
    public bool unsync;
    public bool vram;
    public bool bleed;


    // Start is called before the first frame update
    void Start()
    {
        frosty = false;
        tint = false;
        unsync = false;
        vram = false;
        Frostybool(frosty);
        Tinty(tint);
        Unsyncy(unsync);
        Vramy(vram);
        Bleedy(bleed);
    }

    // Update is called once per frame
    void Update()
    {
        Frostybool(frosty);
        Tinty(tint);
        Unsyncy(unsync);
        Vramy(vram);
    }

    void Frostybool(bool ton)
    {
        if (ton == false)
        {
            GetComponent<FrostEffect>().enabled = false;
        }
        else
        {
            GetComponent<FrostEffect>().enabled = true;
        }
    }

    void Tinty(bool ton)
    {
        if (ton == false)
        {
            GetComponent<ShaderEffect_Tint>().enabled = false;
        }
        else
        {
            GetComponent<ShaderEffect_Tint>().enabled = true;
        }
    }

    void Unsyncy(bool ton)
    {
        if (ton == false)
        {
            GetComponent<ShaderEffect_Unsync>().enabled = false;
        }
        else
        {
            GetComponent<ShaderEffect_Unsync>().enabled = true;
        }
    }

    void Vramy(bool ton)
    {
        if (ton == false)
        {
            GetComponent<ShaderEffect_CorruptedVram>().enabled = false;
        }
        else
        {
            GetComponent<ShaderEffect_CorruptedVram>().enabled = true;
        }
    }

    void Bleedy(bool ton)
    {
        if (ton == false)
        {
            GetComponent<ShaderEffect_BleedingColors>().enabled = false;
        }
        else
        {
            GetComponent<ShaderEffect_BleedingColors>().enabled = true;
        }
    }
}
