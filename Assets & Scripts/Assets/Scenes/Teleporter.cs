using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Teleporter : MonoBehaviour
{
    void OnCollisionCollider(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Teleported");
            SceneManager.LoadScene(0);
        }
    }
}
