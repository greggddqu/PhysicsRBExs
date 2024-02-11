using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearForcer : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(-10.0f* Vector3.right);
        Debug.Log(rb.velocity.magnitude);
    }
}
