using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndCG : MonoBehaviour {

    public VideoPlayer videoPlayer;
    //public Button button;

    // Use this for initialization
    void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		if(!videoPlayer.isPlaying)
        {
            //button.gameObject.SetActive(true);
            SceneManager.LoadScene("Title");
        }
	}

    public void UIEvt_BackToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
