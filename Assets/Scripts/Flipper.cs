// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] HingeJoint2D joint;

    void Start()
    {
        joint = GetComponent<HingeJoint2D>();
    }

    // push space to turn the motor on
    // release space to turn the motor off
    void Update()
    {
        UseRightFlipper();
        UseLeftFlipper();

    }

    private void UseRightFlipper()
    {
        if (Input.GetKey(KeyCode.Slash) && joint.tag == "RightFlipper")
        {
            joint.useMotor = true;

        }
        else if(!Input.GetKey(KeyCode.Slash))
        {
            joint.useMotor = false;
        }
    }

    private void UseLeftFlipper()
    {
        if (Input.GetKey(KeyCode.Z) && joint.tag == "LeftFlipper")
        {
            joint.useMotor = true;

        }
        else if (!Input.GetKey(KeyCode.Slash))
        {
            joint.useMotor = false;
        }
        //else
        //{
        //    joint.useMotor = false;
        //}
    }
}
