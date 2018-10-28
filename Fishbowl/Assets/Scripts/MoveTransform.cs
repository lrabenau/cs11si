using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveTransform : MonoBehaviour {

    // Use this for initialization
    [SerializeField] 
    private Vector3 moveDir;

    [SerializeField] 
    private float speed;



    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(moveDir * speed *Time.deltaTime);

	}
}
