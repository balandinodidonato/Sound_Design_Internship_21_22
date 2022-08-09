using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverbZoneLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Reverb Zone Triggered");

        }



    }
}
