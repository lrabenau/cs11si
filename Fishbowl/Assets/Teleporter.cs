using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

	// Use this for initialization
	public VRTeleporter teleporter;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            teleporter.ToggleDisplay(true);
        }

        if(Input.GetMouseButtonUp(0))
        {
            teleporter.Teleport();
            teleporter.ToggleDisplay(false);
        }
	}
}
