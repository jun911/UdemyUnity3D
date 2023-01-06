using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] float xValue;
    //[SerializeField] float yValue;
    //[SerializeField] float zValue;
    [SerializeField] float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 vec = new Vector3(xValue * Time.deltaTime, yValue * Time.deltaTime, zValue * Time.deltaTime);
        //transform.Translate(vec);

        float xValue = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }
}
