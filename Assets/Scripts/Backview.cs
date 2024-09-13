using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backview : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnMouseDown()

    {
        Camera.main.transform.position = new Vector3(0, 12, 0);
        Camera.main.transform.rotation = Quaternion.Euler(90, 0, 0);
    }
}
