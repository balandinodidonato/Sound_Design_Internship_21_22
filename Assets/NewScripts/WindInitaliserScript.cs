using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindInitaliserScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.SetRTPCValue("WindGainLeft", 0.5f, gameObject);
        AkSoundEngine.SetRTPCValue("WindGainRight", 0.5f, gameObject);
        AkSoundEngine.SetRTPCValue("WindTemperatureLeft", 0, gameObject);
        AkSoundEngine.SetRTPCValue("WindTemperatureRight", 0, gameObject);
        AkSoundEngine.SetRTPCValue("WindForceLeft", 0, gameObject);
        AkSoundEngine.SetRTPCValue("WindForceRight", 0, gameObject);
    }
}
