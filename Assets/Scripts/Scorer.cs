using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    public int scores;

    [SerializeField] int hits;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            //SceneManager.LoadScene(0);

            //hits++;
            Debug.Log($"You're bumped into a thing this many times : {++hits}");
        }
    }
}
