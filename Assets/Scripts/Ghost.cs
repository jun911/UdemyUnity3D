using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] Vector3 dirVec;

    Transform target;
    State state;

    enum State{
        Idle,
        Run,
        Attack
    }

    private void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Idle:
                Run();
                break;
            case State.Run:
                Run();
                break;
            case State.Attack:
                break;
            default:
                break;
        }
    }

    private void Run()
    {
        state = State.Run;
        target = GameManager.instance.player.GetComponent<Transform>();

        dirVec = target.position - transform.position;
        transform.position = transform.position + dirVec * speed * Time.deltaTime;
    }
}
