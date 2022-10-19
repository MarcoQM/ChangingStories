using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2D : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator ani;
    public int direccion;
    public float speed_walk;
    public float speed_run;
    public GameObject target;
    public bool atacando;


    void Start()
    {
        ani = GetComponent<Animator>();
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Comportamientos();
    }

    public void Comportamientos()
    {
        ani.SetBool("run", false);
        cronometro += 1 * Time.deltaTime;
        if(cronometro >= 2)
        {
            rutina = Random.Range(0, 2);
            cronometro = 0;
        }
    
        switch (rutina)
        {
            case 0:
                ani.SetBool("walk", false);
                break;
            case 1:
                direccion = Random.Range(0, 2);
                rutina++;
                break;
            case 2:
                switch(direccion)
                {
                    case 0:
                        //transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                        transform.rotation = Quaternion.Euler(0,0,0);
                        transform.Translate(Vector3.right * speed_walk * Time.deltaTime);
                        break;
                    case 1:
                        //transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
                        transform.rotation = Quaternion.Euler(0,180,0);
                        transform.Translate(Vector3.right * speed_walk * Time.deltaTime);
                        break;
                }
                break;
        }
        
    }
}
