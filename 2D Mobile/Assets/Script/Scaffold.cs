using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaffold : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, 8), transform.position.y);
    }
}
