﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIsControl : MonoBehaviour {

    public Text MoneyView;
    public Slider HappnessBar;

    public characterControl characterControl;
    public PlayerState playerState;
    public characterConfig characterConfig;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        MoneyView.text = "金币：" + characterConfig.money;
        HappnessBar.value = characterConfig.curHappiness / 1000f;
        
	}
}
