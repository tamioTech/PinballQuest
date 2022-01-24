// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    [SerializeField] GameObject outHole;
    [SerializeField] private float upForce = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = outHole.transform.position;
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * upForce);
    }
}