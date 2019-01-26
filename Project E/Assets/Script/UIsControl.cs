using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIsControl : MonoBehaviour {

    public Text MoneyView;
    public Slider HappnessBar;

    public float happness;
    public float happnessMinu = 1.5f;

    public characterControl characterControl;
    public playerState playerState;
    public characterConfig characterConfig;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        MoneyView.text = "金币：" + characterConfig.money;
        HappnessBar.value = characterConfig.happness / 1000f;
        if (playerState.playerlocation == "Home" || playerState.playerlocation == "Chase")
        {
            if(characterConfig.happness <= 1000)
            {
                happness = characterConfig.happness + 5f + characterControl.happness1 ;
            }
            
        }
        else
        {
            happness = happness - happnessMinu;
        }
	}
}
