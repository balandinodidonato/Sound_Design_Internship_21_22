using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterTest : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ellen Footsteps RTPC value was set to 1 (Stone Off)");
        }

    }
}
