using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

    [SerializeField]
    private AudioClip AsteroidDestruction;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = transform.parent.GetComponent<AudioSource>();
        Debug.Log(Inventory.inventory);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        StartCoroutine(PlayExplosion());

    }

    private IEnumerator PlayExplosion()
    {
        audioSource.PlayOneShot(AsteroidDestruction, 1f);
        yield return new WaitForSeconds(AsteroidDestruction.length);
        Destroy(transform.parent.gameObject);
    }
}
