using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 1f;
    [SerializeField] float zValue = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float xMovement = Input.GetAxis("Horizontal") * xValue * Time.deltaTime;
       float zMovement = Input.GetAxis("Vertical") * zValue * Time.deltaTime;
        transform.Translate(xMovement,0,zMovement);
    }
}
