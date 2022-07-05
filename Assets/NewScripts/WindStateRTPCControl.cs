using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindStateRTPCControl : MonoBehaviour
{
    [SerializeField]
    private float WindGainLeft;
    [SerializeField]
    private float WindGainRight;
    [SerializeField]
    private int WindTempLeft;
    [SerializeField]
    private int WindTempRight;
    [SerializeField]
    private int WindForceLeft;
    [SerializeField]
    private int WindForceRight;
   
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.SetRTPCValue("WindGainLeft", WindGainLeft, gameObject);
            AkSoundEngine.SetRTPCValue("WindGainRight", WindGainRight, gameObject);
            AkSoundEngine.SetRTPCValue("WindTemperatureLeft", WindTempLeft, gameObject);
            AkSoundEngine.SetRTPCValue("WindTemperatureRight", WindTempRight, gameObject);
            AkSoundEngine.SetRTPCValue("WindForceLeft", WindForceLeft, gameObject);
            AkSoundEngine.SetRTPCValue("WindForceRight", WindForceRight, gameObject);
        }
    }

}
