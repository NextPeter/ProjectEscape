using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaChase : MonoBehaviour {
    public bool playerInChase;
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
            playerInChase = true;
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            playerInChase = false;
        }

    }
}
