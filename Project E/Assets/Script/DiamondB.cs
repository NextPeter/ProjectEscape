﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondB : MonoBehaviour {

    public bool DiamondBGet;
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
            ui.panelReward.SetActive(true);
            DiamondBGet = true;
        }
    }
}
