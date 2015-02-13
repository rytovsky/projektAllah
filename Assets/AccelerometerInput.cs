using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour {


	void Update () 
	{
		if (transform.position.y < 10)
			transform.localPosition = new Vector3(transform.position.x,1,transform.position.z);
		else
			transform.Translate(Input.acceleration.x*Time.deltaTime*10, 0,Input.acceleration.y *Time.deltaTime*10);
	}
}
