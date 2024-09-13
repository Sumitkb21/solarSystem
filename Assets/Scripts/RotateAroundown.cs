using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class RotateAroundown : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target; // the object to rotate around
    public int speed; // the speed of rotation
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }

    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(target.transform.position, new Vector3( 0 , 0.92f, 0.39f), -speed * Time.deltaTime);

    }
}
