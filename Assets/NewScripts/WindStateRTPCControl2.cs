using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindStateRTPCControl2 : MonoBehaviour
{
    [SerializeField]
    private float WindGainLeft2;
    [SerializeField]
    private float WindGainRight2;
    [SerializeField]
    private int WindTempLeft2;
    [SerializeField]
    private int WindTempRight2;
    [SerializeField]
    private int WindForceLeft2;
    [SerializeField]
    private int WindForceRight2;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.SetRTPCValue("WindGainLeft", WindGainLeft2, gameObject);
            AkSoundEngine.SetRTPCValue("WindGainRight", WindGainRight2, gameObject);
            AkSoundEngine.SetRTPCValue("WindTemperatureLeft", WindTempLeft2, gameObject);
            AkSoundEngine.SetRTPCValue("WindTemperatureRight", WindTempRight2, gameObject);
            AkSoundEngine.SetRTPCValue("WindForceLeft", WindForceLeft2, gameObject);
            AkSoundEngine.SetRTPCValue("WindForceRight", WindForceRight2, gameObject);
        }
    }

}
