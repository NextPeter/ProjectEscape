using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaB : MonoBehaviour {
    public bool playerInB;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            playerInB = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            playerInB = false;
        }

    }
}
