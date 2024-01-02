using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float movePower = 1f;
    public Dispenser[] DispenserList;    
    Dispenser NearDispenser;
    [SerializeField]
    Dispenser PickBeer;
    SpriteRenderer sr;
    Animator ani;
    Rigidbody2D rigid;
    Man man;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        man = GetComponent<Man>();
    }

    private void FixedUpdate()
    {
        Move();
        CheckDispenser();
        InputChecker();
    }

    void Move()
    {
        Vector3 moveHorVelocity = Vector3.zero;
        Vector3 moveVerVelocity = Vector3.zero;
        var _hor = Input.GetAxisRaw("Horizontal");
        var _ver = Input.GetAxisRaw("Vertical");

        if (_hor != 0 || _ver != 0)
        {
            ani.SetBool("IsMove", true);
            if (_hor != 0)
            {
                if (_hor < 0)
                {
                    moveHorVelocity = Vector3.left;
                    sr.flipX = true;
                }
                else
                {
                    moveHorVelocity = Vector3.right;
                    sr.flipX = false;
                }
            }

            if (_ver != 0)
            {
                if (_ver > 0)
                {
                    moveVerVelocity = Vector3.up;
                }
                else
                {
                    moveVerVelocity = Vector3.down;
                }
            }
        }
        else
        {
            ani.SetBool("IsMove", false);
        }

        //transform.position += (moveHorVelocity + moveVerVelocity) * movePower * Time.deltaTime;
        rigid.velocity = new Vector2(_hor * movePower, _ver * movePower);
    }

    void CheckDispenser()
    {
        Dispenser _near = null;
        for (int i = 0; i < DispenserList.Length; i++)
        {
            var dis = Vector2.Distance(this.transform.position, DispenserList[i].gameObject.transform.position);
            if (dis <= 1.4f)
            {
                DispenserList[i].SetGlow(true);
                _near = DispenserList[i];
            }
            else
            {
                DispenserList[i].SetGlow(false);
            }
        }
        NearDispenser = _near;
    }

    void InputChecker()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (NearDispenser != null)
            {
                PickBeer = NearDispenser;
                man.SetSelectedBeer(PickBeer);
            }
        }
    }
}
