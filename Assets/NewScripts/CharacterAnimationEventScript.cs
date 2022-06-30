using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEventScript : MonoBehaviour
{
        public string EllenJumpUp = "Jump";
        public string EllenLandDown = "Land";
        public string EllenLandFastDown = "Land";
        public string EllenAttack = "WeaponSwingNoContact";
        public SwitchCheck Status3;
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);  

    }

    void EllenJump()
    {
        Debug.Log("JumpTriggered");
        if (Status3.IsJumping == false)
        {
            AkSoundEngine.PostEvent(EllenJumpUp, gameObject);
            Status3.IsJumping = true;
        }

    }
    void EllenLand()
    {
        Debug.Log("LandTriggred");
        if (Status3.IsJumping == true)
        {
            AkSoundEngine.PostEvent(EllenLandDown, gameObject);
            Status3.Landed = true;
            Status3.IsJumping = false;
        }
    }
    void EllenLandFast()
    {
        Debug.Log("LandTriggred");
        if (Status3.IsJumping == true)
        {
            AkSoundEngine.PostEvent(EllenLandFastDown, gameObject);
            Status3.Landed = true;
            Status3.IsJumping = false;
        }
    }
    void MeleeAttackStart()
    {
        Debug.Log("AttackTriggred");
        if (Status3.IsJumping == true)
        {
            AkSoundEngine.PostEvent(EllenAttack, gameObject);
            Status3.Landed = true;
            Status3.IsJumping = false;
        }
    }
}
