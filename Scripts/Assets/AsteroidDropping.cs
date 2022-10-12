using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDropping : MonoBehaviour
{
   new MeshRenderer renderer;
    new Rigidbody rigidbody;

    [SerializeField] float timeTilDrop = 0;

    // Start is called before the first frame update
    void Start()
    {
        //cashing references
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>timeTilDrop)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
