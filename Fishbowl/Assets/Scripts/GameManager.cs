using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	// Use this for initialization
	void Start () {
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }



    // Update is called once per frame
    void Update () {
        if (Inventory.inventory.Count >= 2)
        {
            SceneManager.LoadScreen("Scenes/Fishbowl")
        }
        //RaycastHit hit; 
        //if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100.0f)) {
        //    if (hit.distance <= 10f) {
        //        LoadScene("Scenes/SampleScene");
        //    }
        //}
        
    }
}
