using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float playTime;
    public J_Player player;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        playTime = Time.time;
    }
}
