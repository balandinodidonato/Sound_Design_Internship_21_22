using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Gamekit3D.GameCommands
{

    public class SendOnTriggerEnter : TriggerCommand
    {
        public LayerMask layers;
        void OnTriggerEnter(Collider other) //DG update from other to plyr
        {
            if (0 != (layers.value & 1 << other.gameObject.layer)) 
            {
                Send();
            }
        }
    }
}
