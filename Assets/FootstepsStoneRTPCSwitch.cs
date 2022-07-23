using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsStoneRTPCSwitch : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ellen Footsteps RTPC value was set to 2 (Stone On)");
            AkSoundEngine.SetRTPCValue("EllenFootstepsStone", 2.0f, gameObject);


            Debug.Log("Ellen Footsteps RTPC value was set to 3 (Grass Off)");
            AkSoundEngine.SetRTPCValue("EllenFootstepsGrass", 3.0f, gameObject);

        }



    }
}
