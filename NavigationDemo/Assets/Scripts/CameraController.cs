using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	private Vector3 offset;
	public Transform mySelfPalyer;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(mySelfPalyer!=null)
		{
			Vector3 pos = new Vector3(mySelfPalyer.transform.position.x, mySelfPalyer.transform.position.y, mySelfPalyer.transform.position.z);
			transform.position = pos + offset;
			
		}
		
	}
}
