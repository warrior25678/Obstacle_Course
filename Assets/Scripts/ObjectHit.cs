using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        Debug.Log("You hit something. Nice work genius!");
        GetComponent<MeshRenderer>().material.color = Color.magenta;
    }
}
