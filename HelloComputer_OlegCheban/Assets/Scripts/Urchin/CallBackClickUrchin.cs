using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBackClickUrchin : MonoBehaviour {
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void CallBack()
    {
        anim.SetBool("Click", false);
    }
}
