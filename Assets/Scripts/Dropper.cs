using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] float dropTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > dropTime)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
