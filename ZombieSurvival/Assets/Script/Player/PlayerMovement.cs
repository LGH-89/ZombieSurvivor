using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jump;
    Vector3 dir;
    Animator anim;
    CharacterController cc;

    public float speed;

    void Start()
    {
        anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        dir = new Vector3(h, 0, v) * speed;

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.Euler(0, Mathf.Atan2(h, v) * Mathf.Rad2Deg, 0);
            anim.SetBool("movementSpeed", true);
        }
        else anim.SetBool("movementSpeed", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //dir.y = jump;
            anim.SetTrigger("Jump");
            anim.SetBool("movementSpeed", false);
        }
        
        dir.y += Physics.gravity.y * Time.deltaTime;
        cc.Move(dir * Time.deltaTime);
    }
}
