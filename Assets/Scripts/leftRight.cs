using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftRight : MonoBehaviour
{
    // Start is called before the first frame update
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
//https://answers.unity.com/questions/754633/how-to-move-an-object-left-and-righ-looping.html