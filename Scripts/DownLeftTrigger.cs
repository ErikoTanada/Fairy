using System.Collections;using System.Collections.Generic;using UnityEngine;public class DownLeftTrigger : MonoBehaviour{    private Animator anim = null;        void Start()    {        // animatorコンポーネントを取得        anim = GetComponent<Animator>();    }    void Update()    {        float verticalKey = Input.GetAxis("Vertical");                if (verticalKey < 0)        {            anim.SetBool("DownLeft", true);        }        else        {            anim.SetBool("DownLeft", false);        }    }}