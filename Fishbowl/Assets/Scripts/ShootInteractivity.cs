using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootInteractivity : MonoBehaviour {
    public GameObject bulletPrefab;
    public float speed;
    public Transform spawnPoint;

    [SerializeField]
    private AudioClip GunShot;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        //check every frame if trigger has been pulled
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
	}

    public void Shoot()
    {
        GameObject spawnBullet= Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        spawnBullet.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * speed);
        audioSource.PlayOneShot(GunShot);
    }
}
