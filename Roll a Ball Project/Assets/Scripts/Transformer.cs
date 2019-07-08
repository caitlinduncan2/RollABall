using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer : MonoBehaviour
{
  

    public float speed;
    Vector3 pointA = new Vector3(9.0f, 0.0f, 1.0f);
    Vector3 pointB = new Vector3(-9.0f, 0.0f, 1.0f);



    void Update()
    {
       
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
