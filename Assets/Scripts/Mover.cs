using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	public enum motionDirections {Spin, Horizontal, Vertical};
	public motionDirections motionState = motionDirections.Vertical;
	public float spinSpeed = 181.0f;
	public float motionSpeed = 0.1f;

	// Update is called once per frame
	void Update () {
		switch(motionState){
		case motionDirections.Spin:
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);	
			break;
		case motionDirections.Horizontal:
			gameObject.transform.Translate (Vector3.right * Mathf.Cos (Time.timeSinceLevelLoad) * motionSpeed);
			break;
		case motionDirections.Vertical:
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionSpeed);
			break;
		}
}
}
