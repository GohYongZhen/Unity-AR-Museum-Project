using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;
using UnityEngine.Audio;

public class virtualButton : MonoBehaviour
{
    //Videos
    public GameObject rhino;
    public VirtualButtonBehaviour VbR;
    public GameObject whale;
    public VirtualButtonBehaviour VbW;

    //Fossil
    public GameObject rhinof;
    public VirtualButtonBehaviour VbRf;
    public GameObject whalef;
    public VirtualButtonBehaviour VbWf;

    //Audios
    public AudioClip rhinofSound;
    public AudioClip whalefSound;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        VbR.RegisterOnButtonPressed(OnButtonPressed);
        VbR.RegisterOnButtonReleased(OnButtonReleased);

        VbRf.RegisterOnButtonPressed(OnButtonPressed);
        VbRf.RegisterOnButtonReleased(OnButtonReleased);

        VbW.RegisterOnButtonPressed(OnButtonPressed);
        VbW.RegisterOnButtonReleased(OnButtonReleased);

        VbWf.RegisterOnButtonPressed(OnButtonPressed);
        VbWf.RegisterOnButtonReleased(OnButtonReleased);

        rhino.SetActive(false);
        rhinof.SetActive(false);
        whale.SetActive(false);
        whalef.SetActive(false);

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb == VbR)
        {
            rhino.SetActive(true);
            rhinof.SetActive(false);
            whale.SetActive(false);
            whalef.SetActive(false);
        }
        else if(vb == VbRf)
        {
            rhino.SetActive(false);
            rhinof.SetActive(true);
            whale.SetActive(false);
            whalef.SetActive(false);

            audioSource.clip = rhinofSound;
            audioSource.Play();
        }
        else if(vb == VbW)
        {
            rhino.SetActive(false);
            rhinof.SetActive(false);
            whale.SetActive(true);
            whalef.SetActive(false);



        }
        else if(vb == VbWf)
        {
            rhino.SetActive(false);
            rhinof.SetActive(false);
            whale.SetActive(false);
            whalef.SetActive(true);
            audioSource.clip = whalefSound;
            audioSource.Play();
        }


    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vb == VbR)
        {
            rhino.SetActive(false);
            rhinof.SetActive(false);
            whale.SetActive(false);
            whalef.SetActive(false);

        }
        else if (vb == VbRf)
        {
            rhino.SetActive(false);
            rhinof.SetActive(false);
            whale.SetActive(false);
            whalef.SetActive(false);
            audioSource.Stop();
        }
        else if(vb == VbW)
        {
            rhino.SetActive(false);
            rhinof.SetActive(false);
            whale.SetActive(false);
            whalef.SetActive(false);
        }
        else if(vb == VbWf)
        {
            rhino.SetActive(false);
            rhinof.SetActive(false);
            whale.SetActive(false);
            whalef.SetActive(false);
            audioSource.Stop();
        }

    }

}
