using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.Rendering;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer mr;
    Dropper dropper;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                mr.material.color = Color.red;
                gameObject.tag = "Hit";
                break;
            default:
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Player":
                if(tag == "ApproachDrop")
                {
                    tag = "Drop";
                }
                break;
            default:
                break;
        }
    }
}
