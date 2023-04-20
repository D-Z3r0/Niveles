using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionUI : MonoBehaviour
{
    private int puntaje = 0;

    private void OnCollisionEnter(Collision  other) 
    {
        Debug.Log("collision");
        if (gameObject.tag == other.gameObject.tag)
        {
            Destroy(other.gameObject);
            Debug.Log("Collided");
        }
        // if (other.gameObject.CompareTag("3"))
        // {
        //     Destroy(other.gameObject);
        //     Debug.Log("Collided");
        // }
        // if (other.gameObject.CompareTag("4"))
        // {
        //     Destroy(other.gameObject);
        //     Debug.Log("Collided");
        // }
        // if (other.gameObject.CompareTag("5"))
        // {
        //     Destroy(other.gameObject);
        //     Debug.Log("Collided");
        // }
        // if (other.gameObject.CompareTag("6"))
        // {
        //     Destroy(other.gameObject);
        //     Debug.Log("Collided");
        // }
        // if (other.gameObject.CompareTag("7"))
        // {
        //     Destroy(other.gameObject);
        //     Debug.Log("Collided");
        // }
    }
}