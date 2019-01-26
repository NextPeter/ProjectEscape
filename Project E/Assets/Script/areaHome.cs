using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaHome : MonoBehaviour {
    public bool playerInHome;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerInHome = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            playerInHome = true;
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            playerInHome = false;
        }
       
    }
}
