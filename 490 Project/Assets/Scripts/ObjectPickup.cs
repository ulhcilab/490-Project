using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using HTC.UnityPlugin.Vive;

public class ObjectPickup : MonoBehaviour {

    public GameObject menu;

    private Hand hand;
    private GameObject obj;
    private FixedJoint fJoint;    

	// Use this for initialization
	void Start () {
       
        fJoint = GetComponent<FixedJoint>();
        hand = gameObject.GetComponent<Hand>();
    }
	
	// Update is called once per frame
	void Update () {
        if (hand  == null) {
            Debug.Log("Controller not initialized");
            return;
        }        
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(hand.handType)) {
            PickUpObj();
        }
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateUp(hand.handType)) {
            DropObj();
        }
        if (SteamVR_Input._default.inActions.MenuButton.GetState(hand.handType)) {
            if (menu.activeSelf == true)
            {
                menu.SetActive(false);
            }
            else
            {
                menu.SetActive(true);
            }
        }
	}
    void OnTriggerStay(Collider other) {
        if (other.CompareTag("SMachine")) {
            obj = other.gameObject;
        }
    }
    void OnTriggerExit(Collider other) {
        obj = null;
    }
    void PickUpObj() {
        if (obj != null)
        {
            fJoint.connectedBody = obj.GetComponent<Rigidbody>();
        }
        else {
            fJoint.connectedBody = null;
        }
    }
    void DropObj() {
        if (fJoint.connectedBody != null) {
            fJoint.connectedBody = null;
        }
    }
    
}
