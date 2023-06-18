using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{


private void OnTriggerEnter2D(Collider2D other) 
{
    Debug.Log("Enter Collider");
    if(other.gameObject.CompareTag("Trash"))
    {
        Destroy(other.gameObject);
        Debug.Log("Destroy Object");
    }
}
}
