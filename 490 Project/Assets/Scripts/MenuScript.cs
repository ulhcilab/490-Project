using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public GameObject wedge;
	public GameObject plane;
	public GameObject screw;
	public GameObject wheel;
	public GameObject lever;

	public void spawnWedge(){
		Instantiate (wedge, new Vector3(5,1,5), Quaternion.identity);
	}
	public void spawnPlane(){
		Instantiate (plane, new Vector3(5,1,5), Quaternion.identity);
	}
	public void spawnScrew(){
		Instantiate (screw, new Vector3(5,1,5), Quaternion.identity);
	}
	public void spawnWheel(){
		Instantiate (wheel, new Vector3(5,1,5), Quaternion.identity);
	}
	public void spawnlever(){
		Instantiate (lever, new Vector3(5,1,5), Quaternion.identity);
	}
}
