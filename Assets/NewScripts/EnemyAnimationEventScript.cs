using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationEventScript : MonoBehaviour
{
    void ChomperDeath()
    {
        Debug.Log("ChomperDeath");
        AkSoundEngine.PostEvent("ChomperDeath", gameObject);
    }
}
