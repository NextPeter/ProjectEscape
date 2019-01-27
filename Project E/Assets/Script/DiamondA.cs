using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondA : MonoBehaviour {

    public bool DiamondAGet;
    public UIsControl ui;
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
            ui.panelHomesick.SetActive(true);
            DiamondAGet = true;
        }
    }
}
