using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChontroller : MonoBehaviour {

    public characterConfig characterConfig;
    public float AISpeed;
    public Transform CharacterTrans;
    private Animator anim;
    public bool AIGetA;
    public bool catchPlayer;
    public playerState playerState;

    float SpeedUp = 40f;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        AIGetA = false;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(playerState.playerlocation == "Chase")
        {
            AISpeed = characterConfig.AISpeed;
            Vector2 character = new Vector2(CharacterTrans.transform.position.x, CharacterTrans.transform.position.y);

            transform.position = Vector3.MoveTowards(transform.position, character, Time.deltaTime * SpeedUp * AISpeed);


            if (CharacterTrans.transform.position.x > 0)
            {
                anim.SetBool("right", true);
                anim.SetBool("left", false);
            }
            else if (CharacterTrans.transform.position.x < 0)
            {
                anim.SetBool("left", true);
                anim.SetBool("right", false);
            }
            else
            {
                anim.SetBool("left", false);
                anim.SetBool("right", false);
            }

            if (CharacterTrans.transform.position.y != 0)
            {
                if (CharacterTrans.transform.position.x > 0)
                {
                    anim.SetBool("right", true);
                    anim.SetBool("left", false);
                }
                else if (CharacterTrans.transform.position.x < 0)
                {
                    anim.SetBool("left", true);
                    anim.SetBool("right", false);
                }
                else
                {
                    anim.SetBool("left", false);
                    anim.SetBool("right", true);
                }
            }
        }else if(playerState.playerlocation  == "A")
        {

        }
    }

        

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            AIGetA = true;
        }
        if (collision.gameObject.layer == 8)
        {
            catchPlayer = true;
        }
    }
}

