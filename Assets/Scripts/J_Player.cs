using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

public class J_Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Vector3 dir;
    [SerializeField] float rotationSpeed = 10;
    [SerializeField] float dirMagnitude;

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxisRaw("Horizontal");
        float zValue = Input.GetAxisRaw("Vertical");

        dir = new Vector3(xValue, 0f, zValue);
        dirMagnitude = dir.magnitude;

        //transform.Translate(xValue, 0, zValue);
        transform.position = transform.position +  dir * speed * Time.deltaTime;

        if(dirMagnitude > 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotationSpeed);
        }

        animator.SetFloat("speed", dirMagnitude);
    }
}
