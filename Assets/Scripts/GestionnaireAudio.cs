using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GestionnaireAudio : MonoBehaviour
{

    [SerializeField]
    private AudioMixer audioMixer;

    public void AjusterVolumeMusique(float volume)
    {
        Debug.Log("AjusterVolumeMusique called volume: " + volume);
        audioMixer.SetFloat("VolumeMusique", volume);
    }

    public void AjusterVolumeEffets(float volume)
    {
        Debug.Log("AjusterVolumeEffets called volume: " + volume);
        audioMixer.SetFloat("VolumeEffets", volume);
        audioMixer.SetFloat("VolumeMusiquesEffets", volume);
    }

}
