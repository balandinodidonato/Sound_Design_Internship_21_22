using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRTPCControl : MonoBehaviour
{
    //All the Int Variables will only accept 0,1 as input parameters. The floats will accept any number between 0 & 1. -DG
    [SerializeField]
    private float DrumsGain;
    [SerializeField]
    private float MelodyGain;
    [SerializeField]
    private float Melody2Gain;
    [SerializeField]
    private float ChordsGain;
    [SerializeField]



    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.SetRTPCValue("DrumsGain", DrumsGain, gameObject);
            AkSoundEngine.SetRTPCValue("MelodyGain", MelodyGain, gameObject);
            AkSoundEngine.SetRTPCValue("Melody2Gain", ChordsGain, gameObject);
            AkSoundEngine.SetRTPCValue("ChordsGain", ChordsGain, gameObject);
            Debug.Log("MusicChangeTriggered");
        }
    }

}
