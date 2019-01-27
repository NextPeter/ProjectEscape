using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AIChontroller : MonoBehaviour {

    public characterConfig characterConfig;
    public float AISpeed;
    public Transform CharacterTrans;
    private Animator anim;
    public bool AIGetA;
    public PlayerState playerState;

    public lightControl lightControl;
    public characterControl characterControl;
    public Rigidbody2D rigid;

    float SpeedUp = 40f;
    Vector3 startUpPosition;
    bool isReset = false;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        AIGetA = false;
        startUpPosition = transform.position;

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(isReset)
        {
            isReset = false;
            transform.position = startUpPosition;
            return;
        }
        if(playerState.playerlocation == "Chase")
        {
            AISpeed = characterConfig.AISpeedPercent * characterConfig.characterSpeed;
            Vector2 character = new Vector2(CharacterTrans.transform.position.x, CharacterTrans.transform.position.y);



            rigid.MovePosition((Vector2)transform.position + Time.deltaTime * AISpeed * (character - (Vector2)transform.position).normalized);


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
        if (collision.gameObject.layer == 8 && playerState.playerState == PlayerStateEnum.Esacaping)
        {
            isReset = true;
            characterConfig.DataReset();
            playerState.DataReset();
            characterControl.DataReset();
            //if(playerState.playerState == PlayerStateEnum.Esacaping)
            //{
            //    lightControl.SetToZero(() =>
            //    {
            //        CharacterTrans.position = startUpPosition;
            //        //lightControl.DataReset();
            //        characterConfig.DataReset();
            //        playerState.DataReset();
            //        characterControl.DataReset();
            //    },
            //    () =>
            //    {
            //        ;
            //    });
            //}
        }
    }
}

