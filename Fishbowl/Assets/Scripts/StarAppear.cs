using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAppear : MonoBehaviour {
    [SerializeField]
    private GameObject star;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.childCount == 0)
        {
            star.SetActive(true);
        }
	}
}
