using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // #if UNITY_EDITOR
        // #else if bUNITY_ANDROID
        //if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger) || Input.GetKeyDown(KeyCode.Space)) {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.up, out hit, 100.0f))
            {
                if (hit.distance <= 100f)
                {
                    if (hit.collider.gameObject.tag == "sceneSwitcher"){ 
                        // if (tag == x)
                        // sceneName=y
                        GameManager.Instance.LoadScene("Scenes/space");

                    }
                }
            }
        //}
	}
}
