using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    private float time = 1f;
    private bool intent = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetBool("Open", GameManager.instance.GetDoor());

        if (GameManager.instance.GetIntent())
        {
            anim.SetBool("OpenIntent", GameManager.instance.GetIntent());
            intent = true;
        }

        if (intent)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                time = 1;
                intent = false;
                GameManager.instance.SetIntent(false);
                anim.SetBool("OpenIntent", GameManager.instance.GetIntent());
            }
        }
    }
}
