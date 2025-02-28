using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Gamekit3D.GameCommands
{

    public class SendOnTriggerEnterWwiseSw2 : TriggerCommand
    {
        public LayerMask layers;
        public SwitchCheck StatusChecker;
        private string WwiseSend = "CrystalActivate"; //DG Added Line
        void OnTriggerEnter(Collider other)
        {
            if (0 != (layers.value & 1 << other.gameObject.layer) && (StatusChecker.Switch2 = true))
            {
                Send();
                AkSoundEngine.PostEvent(WwiseSend, gameObject);
                Debug.Log("ChimeActivated");
                StatusChecker.Switch2 = false;
            }
        }
    }
}
