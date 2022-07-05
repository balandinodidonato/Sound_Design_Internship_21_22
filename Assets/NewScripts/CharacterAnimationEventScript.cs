using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEventScript : MonoBehaviour
{
        public string EllenJumpUp = "Jump";
        public string EllenLandDown = "Land";
        public string EllenLandFastDown = "Land";
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

    void Combo1()
    {
        Debug.Log("Attack1 Triggered"); 
        AkSoundEngine.PostEvent("WeaponSwing1", gameObject);
    }
    void Combo2()
    {
        Debug.Log("Attack2 Triggered");
        AkSoundEngine.PostEvent("WeaponSwing2", gameObject);
    }
    void Combo3()
    {
        Debug.Log("Attack3 Triggered");
        AkSoundEngine.PostEvent("WeaponSwing3", gameObject);

    }
    void Combo4()
    {
        Debug.Log("Attack4 Triggered");
        AkSoundEngine.PostEvent("WeaponSwing4", gameObject);
        Status3.Combo1 = true;
    }
}
