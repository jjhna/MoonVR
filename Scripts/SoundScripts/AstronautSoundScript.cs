using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautSoundScript : MonoBehaviour
{
    AudioSource Audiomasta;
    private IEnumerator waiterOn;
    private int nextClip;
    [SerializeField]
    private List<AudioClip> SoundTiles = new List<AudioClip>();

    // Start is called before the first frame update
    void Start()
    {
        nextClip = 0;
        Audiomasta = GetComponent<AudioSource>();
        waiterOn = waiter();
        StartCoroutine(waiterOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter()
    {
        while (true)
        {
            yield return new WaitForSeconds(60);
            if (nextClip >= 21)
            {
                Audiomasta.clip = SoundTiles[0];
            }
            else
            {
                nextClip++;
                Audiomasta.clip = SoundTiles[nextClip];
            }
            Audiomasta.Play();
        }
    }
}