using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Frontview : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnMouseDown()
    {
      
        Camera.main.transform.position = new Vector3(0, 2, -25);
        Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

}