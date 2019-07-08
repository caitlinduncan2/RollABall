using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer2 : MonoBehaviour
{


    public float speed;
    Vector3 pointA = new Vector3(-52.15f, 0.0f, 4.88f);
    Vector3 pointB = new Vector3(-67.93f, 0.0f, 4.88f);



    void Update()
    {

        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
