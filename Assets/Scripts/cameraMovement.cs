using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public float movementSpeed = 10f; // Adjust this to control the speed of camera movement

    // Update is called once per frame
    void Update()
    {
        // Check for key presses and move the camera accordingly
        if (Input.GetKey(KeyCode.W)) // Move forward
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) // Move backward
        {
            transform.Translate(Vector3.back * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) // Move left
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) // Move right
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow)) // Move up
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)) // Move down
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }
        // You can add more keys for different movements (up, down, rotate, etc.) as needed
    }
}