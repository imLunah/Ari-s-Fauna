using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float playerSpeed = 0;
    new Rigidbody rigidbody;
   

    void Start() 
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer ()
    {
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed; //Updating every frame
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed; //Frame rate independent

        
        
        transform.Translate(-xValue,0,zValue);
    }

}
