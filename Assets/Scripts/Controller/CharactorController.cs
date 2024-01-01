using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorController : MonoBehaviour
{
    public float movePower = 1f;
    SpriteRenderer sr;
    Animator ani;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ani = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
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

        transform.position += (moveHorVelocity + moveVerVelocity) * movePower * Time.deltaTime;
    }
}
