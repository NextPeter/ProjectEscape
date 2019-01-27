using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class StartCG : MonoBehaviour {

    public VideoPlayer videoPlayer;

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		if(!videoPlayer.isPlaying || Input.GetKeyUp(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }
	}
}
