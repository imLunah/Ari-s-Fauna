using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport1 : MonoBehaviour
{
    void OnCollisionCollider(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Teloported");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
