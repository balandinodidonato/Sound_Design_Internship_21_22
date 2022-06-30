using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSoundsScript : MonoBehaviour
{
    public string Contents = "PlayHealthReleased";
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    void HealthReleased()
    {
        Debug.Log("HealthReleased");
        AkSoundEngine.PostEvent(Contents, gameObject);
    }
}
