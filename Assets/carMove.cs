using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{
    public float MovementSpeed = 1;
    void Start()
    {

    }

    void Update()
    {
        var mvmt = Input.GetAxis("Horizontal");
        transform.position += new Vector3(mvmt, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}
