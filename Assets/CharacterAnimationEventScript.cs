using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEventScript : MonoBehaviour
{
        public string EllenJumpUp = "Jump";
        public string EllenLandDown = "Land";
        public string EllenLandFastDown = "Land";
        public string EllenAttack = "WeaponSwingNoContact";
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);  
    }

    void EllenJump()
    {
        Debug.Log("JumpTriggered");
        AkSoundEngine.PostEvent(EllenJumpUp, gameObject);
    }
    void EllenLand()
    {
        Debug.Log("LandTriggred");
        AkSoundEngine.PostEvent(EllenLandDown, gameObject);
    }
    void EllenLandFast()
    {
        Debug.Log("LandTriggred");
        AkSoundEngine.PostEvent(EllenLandFastDown, gameObject);
    }
    void MeleeAttackStart()
    {
        Debug.Log("AttackTriggred");
        AkSoundEngine.PostEvent(EllenAttack, gameObject);
    }
}
