using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class DiscForcer : MonoBehaviour
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
        newSize0 = newSize.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timenow += Time.deltaTime;
        newSize.y = newSize0 * (1.0f + (0.5f* Mathf.Sin(0.6f*timenow)));
        transform.localScale = newSize;
        rb.AddTorque(myTorque);
        Debug.Log(rb.angularVelocity.magnitude);
    }
}
