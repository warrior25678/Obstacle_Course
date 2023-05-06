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
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("The goal is to get from one end of the level to the other while avoiding obstacles.");
        Debug.Log("Your score is based on the number of objects you hit!");
    }

    void MovePlayer()
    {
        float xMovement = Input.GetAxis("Horizontal") * xValue * Time.deltaTime;
        float zMovement = Input.GetAxis("Vertical") * zValue * Time.deltaTime;
        transform.Translate(xMovement,0,zMovement);
    }
}
