using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer3 : MonoBehaviour
{


    public float speed;
    Vector3 pointA = new Vector3(-52.08f, 0.0f, -3.59f);
    Vector3 pointB = new Vector3(-68.0f, 0.0f, -3.59f);



    void Update()
    {

        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
