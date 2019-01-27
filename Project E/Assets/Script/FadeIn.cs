using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public GameObject Button;

	// Use this for initialization
	void Start () {
        GetComponent<Image>().DOFade(1f, 5f).OnComplete(() => Button.SetActive(true));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UIEvt_BackToTitle()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
    }
}
