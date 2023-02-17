using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAndRotate : MonoBehaviour
{
    public Transform target;
    public float speed;


    void FixedUpdate()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
