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
           
            if (Physics.Raycast(transform.position, transform.up, out hit, 10.0f))
            {
                Debug.Log("HIT");
                Debug.Log(hit.collider.gameObject.tag);
                if (hit.distance <= 5f)
                {
                    if (hit.collider.gameObject.tag == "spaceScene"){ 
                        // if (tag == x)
                        // sceneName=y
                        GameManager.Instance.LoadScene("Scenes/space");

                    }
                    if (hit.collider.gameObject.tag == "birdScene")
                    {

                        GameManager.Instance.LoadScene("Scenes/Snow_birds");

                    }
                    if (hit.collider.gameObject.tag == "fishbowlScene")
                    {
                        Debug.Log("hit");
                        GameManager.Instance.LoadScene("Scenes/Fishbowl");

                    }
                }
            }
        //}
	}
}
