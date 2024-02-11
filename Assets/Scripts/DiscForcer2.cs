using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscForcer2 : MonoBehaviour
{
    Rigidbody rb;
    Vector3 myTorque;
    Vector3 newSize;
    float newSize0;
    float timenow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myTorque = new Vector3(10, 0, 0);
        //rb.AddTorque(myTorque);
        newSize = transform.localScale;
        newSize0 = 2.0f*newSize.y;
        newSize.y = newSize0;
        transform.localScale = newSize;
        transform.position = -2.0f * Vector3.right;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddTorque(myTorque);
        //rb.AddRelativeTorque(myTorque);

    }
}
