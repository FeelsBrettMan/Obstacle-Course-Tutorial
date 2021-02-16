using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rB;
    [SerializeField] float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rB = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rB.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timer)
        {
            renderer.enabled = true;
            rB.useGravity = true;
        }
    }
}
