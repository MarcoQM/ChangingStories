using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction : MonoBehaviour
{
    public Transform ObjectToFollow = null;
    public float Speed;


    private void Awake() {
        ObjectToFollow = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ObjectToFollow == null)
            return;

        //transform.Translate(ObjectToFollow.transform.position, Speed * Time.deltaTime);
        transform.position = Vector2.MoveTowards(transform.position, ObjectToFollow.transform.position, Speed * Time.deltaTime);
        transform.up = ObjectToFollow.position - transform.position;
    }
}
