using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAppear : MonoBehaviour {
    [SerializeField]
    private GameObject star;
    public GameObject camera;
    private bool firstTime;
    private float startTime;
    public float speed = 2.0f;
    private float journeyLength;
    private Vector3 startPosition;
    private Vector3 cameraPosition;

	// Use this for initialization
	void Start () {
		firstTime = true;

	}	
	
	// Update is called once per frame
	void Update () {

		// float distCovered = (Time.time - startTime) * speed;
  //       float fracJourney = distCovered / journeyLength;
  //       star.transform.position = Vector3.Lerp(startPosition, cameraPosition, fracJourney);
           
		if (transform.childCount == 32 && firstTime)
        {
        	startTime = Time.time;
			star.SetActive(true);
			startPosition = star.transform.position;
        	cameraPosition = camera.transform.position;
        	cameraPosition[2] += 2f;
        	cameraPosition[1] -= 2f;
			journeyLength = Vector3.Distance(startPosition, cameraPosition);
			firstTime = false;
        }
        if (!firstTime && star != null) {
        	float distCovered = (Time.time - startTime) * speed;
        	float fracJourney = distCovered / journeyLength;
        	star.transform.position = Vector3.Lerp(startPosition, cameraPosition, fracJourney);
        }
        if (star == null) {
        	Inventory.inventory.Add("STAR");
        	GameManager.Instance.LoadScene("Scenes/Fishbowl");
        }
	}
}
