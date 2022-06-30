using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Gamekit3D.GameCommands
{

    public class SendOnTriggerEnterDGVerSw1 : TriggerCommand
    {
        public LayerMask layers;
        public SwitchCheck StatusChecker;
        private string WwiseSend = "CrystalActivate"; //DG Added Line
        void OnTriggerEnter(Collider other)
        {
            if (0 != (layers.value & 1 << other.gameObject.layer) && (StatusChecker.Switch1 = true))
            {
                Send();
                AkSoundEngine.PostEvent(WwiseSend, gameObject);
                Debug.Log("ChimeActivated");
                StatusChecker.Switch1 = false;
                StatusChecker.Switch2 = true;
            }
        }
    }
}
