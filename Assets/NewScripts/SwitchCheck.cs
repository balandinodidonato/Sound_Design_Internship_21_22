using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCheck : MonoBehaviour
{
    public bool PressurePad1;
    public bool PressurePad2;
    public bool Switch1;
    public bool Switch2;
    public bool Switch3;
    public bool Health1;
    public bool Health2;
    public bool IsJumping;
    public bool Landed;

    // Start is called before the first frame update
    void Start()
    {
        PressurePad1 = true;
        PressurePad2 = false;
        Switch1 = false;
        Switch2 = false;
        Switch3 = false;
        Health1 = true;
        Health2 = true;
        IsJumping = false;
        Landed = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
