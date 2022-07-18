using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        AkSoundEngine.PostEvent("Play_WeaponPickup", gameObject);
        AkSoundEngine.PostEvent("Stop_WeaponPickUpAmbience", gameObject);
    }
}
