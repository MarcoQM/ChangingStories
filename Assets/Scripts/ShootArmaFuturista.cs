using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArmaFuturista : MonoBehaviour
{
    public GameObject Rocket;
    public int LaunchForce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            ShootRocket();
        }
    }

    void ShootRocket()
    {
        GameObject RocketIns = Instantiate(Rocket, transform.position, transform.rotation);
        RocketIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce);
    }
}
