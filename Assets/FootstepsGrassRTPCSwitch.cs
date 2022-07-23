using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsGrassRTPCSwitch : MonoBehaviour
{
    public uint EllenFootstepsGrassID;
    private bool EllenEllenFootstepsGrassActive = false;

    private float EllenFootstepsGrassVersion4;
    private float EllenFootstepsStoneVersion1;

    void Start()
    {
        EllenFootstepsGrassVersion4 = 4.0f;
        EllenFootstepsStoneVersion1 = 1.0f;

        AkSoundEngine.SetRTPCValue("EllenFootstepsGrass", EllenFootstepsGrassVersion4, gameObject);

    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ellen Footsteps RTPC value was set to 1 (Stone Off)");
            AkSoundEngine.SetRTPCValue("EllenFootstepsStone", EllenFootstepsStoneVersion1, gameObject);
                    
        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ellen Footsteps RTPC value was set to 4 (Grass On)");
            AkSoundEngine.SetRTPCValue("EllenFootstepsGrass", EllenFootstepsGrassVersion4, gameObject);
        }

    }
}
