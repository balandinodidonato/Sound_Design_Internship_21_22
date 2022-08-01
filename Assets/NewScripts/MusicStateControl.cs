using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStateControl : MonoBehaviour
{
    //All the Int Variables will only accept 0,1 as input parameters. The floats will accept any number between 0 & 1. -DG
    [SerializeField]
    private float MusicState;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AkSoundEngine.SetRTPCValue("MusicState", MusicState, gameObject);

            Debug.Log("MusicChangeTriggered");
        }
    }

}
