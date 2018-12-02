using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactPointScript : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Contact Point" && collision.transform.parent.GetComponent<FixedJoint>() == null) {
            transform.parent.gameObject.AddComponent<FixedJoint>();
            transform.parent.gameObject.GetComponent<FixedJoint>().connectedBody = collision.transform.parent.GetComponent<Rigidbody>();
            transform.parent.gameObject.GetComponent<FixedJoint>().breakForce = 100000;

            //collision.transform.parent.transform.parent = transform.parent;
        }
    }
    void OnTriggerExit(Collider collision){
        if (collision.gameObject.tag == "Contact Point") {
            Destroy(transform.parent.gameObject.GetComponent<FixedJoint>());
        }
    }
}
