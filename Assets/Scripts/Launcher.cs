using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] float launchSpeed = 200f;
    [SerializeField] Rigidbody2D ballRb;
    

    bool isInLaunchArea;

    private void Awake()
    {
        isInLaunchArea = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Period))
        {
            print("keyPress");
            if (isInLaunchArea)
            {
                print("addForce");
                ballRb.AddForce(Vector2.up * launchSpeed);

            }


        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            isInLaunchArea = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            isInLaunchArea = false;
        }
    }
}
