using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSabor : MonoBehaviour {

    [SerializeField]
    private GameObject cubeExplosionPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Destructible")
        {
            Instantiate(cubeExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }

    }
}
