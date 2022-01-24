using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheHole : MonoBehaviour
{

    [SerializeField] GameObject launcher;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(DownTheHole(collision));
    }

    IEnumerator DownTheHole(Collider2D collision)
    {
        yield return new WaitForSeconds(1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        collision.transform.position = launcher.transform.position;
        FindObjectOfType<BallStopTrigger>().DeactivateBallStop();
    }
}
