using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
	public static List<string> inventory = new List<string>();
	public GameObject win;
	public GameObject koi;
	private bool isGameOver = false;
	public GameObject camera;
	public GameObject winMsg;
	public AudioClip audio;
	private bool hasPlayedAudio;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		hasPlayedAudio = false;
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(inventory.Count == 0 && !hasPlayedAudio) {
			audioSource.PlayOneShot(audio, 1f);
			hasPlayedAudio = true;
		}
		if(inventory.Count >= 2 && !isGameOver) {
			if(win != null && koi != null) {
				win.transform.position = camera.transform.position;
				Vector3 finalPos = win.transform.position;
				finalPos[0] += 70f;
				win.transform.position = finalPos;
				// win.transform.Rotate(270, 90, 90);
				float x = 0f;
				float y = 180f;
				float z = 90f;
				Vector3 angles = new Vector3(0f, 180f, 90f);
				win.transform.eulerAngles = angles;
				finalPos[0] += 3f;
				winMsg.transform.position = finalPos;

				Destroy(koi);
				Instantiate(win);
				Instantiate(winMsg);
				isGameOver = true;
			}
		}
	}
}
