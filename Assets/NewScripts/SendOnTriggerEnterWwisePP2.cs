using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Gamekit3D.GameCommands
{

    public class SendOnTriggerEnterWwisePP2 : TriggerCommand
    {
        public LayerMask layers;
        public SwitchCheck StatusChecker;
        private string WwiseSend = "CrystalActivate"; //DG Added Line
        void OnTriggerEnter(Collider other)
        {
            if (0 != (layers.value & 1 << other.gameObject.layer) && (StatusChecker.PressurePad2 = true))
            {
                Send();
                AkSoundEngine.PostEvent(WwiseSend, gameObject);
                Debug.Log("ChimeActivated");
                StatusChecker.PressurePad2 = false;
                StatusChecker.Switch1 = true;
            }
        }
    }
}