using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public float speed;
    public bool jump;
    public Animator animCon;
    void Update()
    {
        animCon.SetFloat("speed",speed);
        if (jump)
        {
            animCon.ResetTrigger("jump");
            animCon.SetTrigger("jump");
            jump = false;
        }
    }
}
