using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIsControl : MonoBehaviour {

    public Text MoneyView;
    public Slider HappnessBar;

    public characterControl characterControl;
    public PlayerState playerState;
    public characterConfig characterConfig;

    public GameObject panelFreedom;
    public GameObject panelHomesick;
    public GameObject panelReward;

    // Use this for initialization
    void Start () {
        panelFreedom.SetActive(false);
        panelHomesick.SetActive(false);
        panelReward.SetActive(false);
        //panelEnd1.SetActive(false);
        //panelEnd2.SetActive(false);
        //panelEnd3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        MoneyView.text = "金币：" + characterConfig.money;
        HappnessBar.value = characterConfig.curHappiness / 1000f;
        
	}

    public void BackToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
