using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerController : MonoBehaviour {
    private bool hasVisitedSpace;
    private bool hasVisitedBird;
    // Use this for initialization
	void Start () {
		hasVisitedSpace = false;
        hasVisitedBird = false;
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
                    if (hit.collider.gameObject.tag == "spaceScene" && !hasVisitedSpace){ 
                        // if (tag == x)
                        // sceneName=y
                        hasVisitedSpace = true;
                        GameManager.Instance.LoadScene("Scenes/space");

                    }
                    if (hit.collider.gameObject.tag == "birdScene" && !hasVisitedBird)
                    {
                        Inventory.inventory.Add("BIRD");
                        hasVisitedBird = true;
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
