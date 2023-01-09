using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3.0f;

    Rigidbody rigidbody;
    MeshRenderer meshRenderer;

    public bool isApproach = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    private void Update()
    {
        Drop();
    }

    public void Drop()
    {
        if (rigidbody.useGravity)
        {
            return;
        }

        Debug.Log("tag:" + tag);

        if(tag == "Drop" && GameManager.instance.playTime > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
