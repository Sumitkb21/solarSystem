using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at

	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Called when MouseDown on this gameObject
	public void OnMouseDown () {
        // change the target of the LookAtTarget script to be this gameobject.
        Debug.Log("yahi hai : " +  target.tag);
        LookAtTarget.target = target;
        // change the field of view on the perspective camera based on the distance from center of world, clamp it to a reasonable field of view
        Camera.main.transform.position = new Vector3(0,2,-20);
        Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
        Camera.main.fieldOfView = Mathf.Clamp(10 * target.transform.localScale.x, 1, 100);
	}
}
