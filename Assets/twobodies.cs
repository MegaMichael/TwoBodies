using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twobodies : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;

    private float mass1;
    private float mass2;

    private Vector3 r1;
    private Vector3 r2;
    private Vector3 r;

    private Vector3 start_impulse;

    private float d;

    private float G = 10;


    void Start()
    {
        start_impulse = new Vector3(0, 2, 0);
        obj1.GetComponent<Rigidbody>().AddForce(start_impulse, ForceMode.Impulse);

        mass1 = obj1.GetComponent<Rigidbody>().mass;
        mass2 = obj2.GetComponent<Rigidbody>().mass;
    }

    void Update()
    {
        r1 = obj1.transform.position;
        r2 = obj2.transform.position;
        r = r2 - r1;
        d = r.magnitude;
        r.Normalize();

        obj1.GetComponent<Rigidbody>().AddForce(r * mass1 * mass2 * G / (d * d));
    }
}
