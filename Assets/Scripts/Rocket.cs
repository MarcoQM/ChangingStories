using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float x;
    public bool lateStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lateStart == false)
        {
            x = transform.localEulerAngles.z;
            lateStart = true;
        }
        transform.rotation = Quaternion.Euler(0, 0, x);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Circle")
        {
            x -= 6;
        }

        //
    }
}
