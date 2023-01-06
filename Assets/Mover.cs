using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float xValue;
    public float yValue;
    public float zValue;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
        //transform.Translate(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue * Time.deltaTime, yValue * Time.deltaTime, zValue * Time.deltaTime);
    }
}
