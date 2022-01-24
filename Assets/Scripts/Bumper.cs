using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    [SerializeField] private float bumperForceMultiplier = 20f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(collision.gameObject.GetComponent<Rigidbody2D>().velocity * bumperForceMultiplier);
        print(collision.gameObject.GetComponent<Rigidbody2D>().velocity);
    }
    
}
