using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStopTrigger : MonoBehaviour
{
    [SerializeField] GameObject ballStopper;

    private void Awake()
    {
        ballStopper.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ballStopper.SetActive(true);
    }

    public void DeactivateBallStop()
    {
        ballStopper.SetActive(false);
    }
}
