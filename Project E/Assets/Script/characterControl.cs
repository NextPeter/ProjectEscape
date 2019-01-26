using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour {


    public float mainCharacterSpeed;

    Transform CharacterTrans;
    Rigidbody2D CharacterRigid;
    private Animator anim;
    public endTrigger endTrigger;
    float SpeedUp = 10f;
    public Transform home;
    public characterConfig characterConfig;

    // Use this for initialization

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");  //获取水平轴（AD）的控制信息
        float v = Input.GetAxisRaw("Vertical");    //获取垂直轴（WS）的控制信息

        mainCharacterSpeed = characterConfig.characterSpeed; //从characterConfig获取速度

        Vector2 input = new Vector2(h, v);      //用二元数组定义控制的信息

        transform.Translate(mainCharacterSpeed*h, mainCharacterSpeed*v, 0);

        if (h > 0)
        {
            anim.SetBool("right", true);
            anim.SetBool("left", false);
        }
        else if (h < 0)
        {
            anim.SetBool("left", true);
            anim.SetBool("right", false);
        }
        else
        {
            anim.SetBool("left", false);
            anim.SetBool("right", false);
        }

        if(v != 0 )
        {
            if(h > 0)
            {
                anim.SetBool("right", true);
                anim.SetBool("left", false);
            }
            else if (h < 0)
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




        if (endTrigger.backHome == true)
        {
            Vector2 character = new Vector2(home.transform.position.x, home.transform.position.y);

            transform.position = Vector3.MoveTowards(transform.position, character, Time.deltaTime * SpeedUp );



                anim.SetBool("left", true);
                anim.SetBool("right", false);

            return;
        }
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            characterConfig.AddMoney();

        }
    }
}
