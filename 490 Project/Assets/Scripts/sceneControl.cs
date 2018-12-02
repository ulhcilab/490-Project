using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneControl : MonoBehaviour {
	public GameObject menu;

	void Update () {
		if(Input.GetKey(KeyCode.A)){
			this.transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
		}
		if(Input.GetKey(KeyCode.D)){
			this.transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
		}
		if(Input.GetKey(KeyCode.W)){
			this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.5f);
		}
		if(Input.GetKey(KeyCode.S)){
			this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.5f);
		}
		if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Escape)){
			if(menu.activeSelf == true){
				menu.SetActive (false);
			}else{
				menu.SetActive (true);
			}
		}

	}
}
