using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllenFootstepsRTPCVersionIntScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.SetRTPCValue("EllenFootstepsRTPCVersion", 0f, gameObject);
    }


}
