using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    private float defaultFieldOfView; // Variable to store the default field of view
    public GameObject target;


    private void Start()
    {
        // Store the default field of view when the game starts
        defaultFieldOfView = Camera.main.fieldOfView;
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
        }

    }

    public void OnMouseDown()
    {
        // Set camera position and rotation
        LookAtTarget.target = target;

        Debug.Log("form reset this: " + LookAtTarget.target);

        Camera.main.transform.position = new Vector3(0,33, 0);
        Camera.main.transform.rotation = Quaternion.Euler(90, 0, 0);
       
        // Change the target of the LookAtTarget script to be this gameobject.
        // (Assuming there's a LookAtTarget script attached to the camera)


        // Reset the field of view to its default value
        Camera.main.fieldOfView = defaultFieldOfView;
    }
}
