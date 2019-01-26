using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaA : MonoBehaviour {

    public bool playerInA;
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
            playerInA = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            playerInA = false;
        }

    }
}
