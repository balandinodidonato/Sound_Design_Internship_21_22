using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInitaliserScript : MonoBehaviour
{

    private float DrumsGain;

    private float MelodyGain;

    private float Melody2Gain;

    private float ChordsGain;

    private float MusicState;
    // Start is called before the first frame update
    void Start()
    {
        DrumsGain = 0;
        MelodyGain = 0;
        Melody2Gain = 0;
        ChordsGain = 0.08f;
        MusicState = 0.5f;
        AkSoundEngine.SetRTPCValue("MusicState", MusicState, gameObject);
        AkSoundEngine.SetRTPCValue("DrumsGain", DrumsGain, gameObject);
        AkSoundEngine.SetRTPCValue("MelodyGain", MelodyGain, gameObject);
        AkSoundEngine.SetRTPCValue("Melody2Gain", ChordsGain, gameObject);
        AkSoundEngine.SetRTPCValue("ChordsGain", ChordsGain, gameObject);
    }

 
}
