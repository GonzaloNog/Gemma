using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanca : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetBool("Open",GameManager.instance.GetTanca());
    }
}
