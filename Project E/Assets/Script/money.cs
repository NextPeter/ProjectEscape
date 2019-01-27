using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour {

    public AudioSource Audio;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            Audio.Play();
            gameObject.SetActive(false);
            
        }
    }
}
