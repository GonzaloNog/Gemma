using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Material mat;
    private Color col;
    void Start()
    {
        mat.color = Color.black;
    }

    private void OnCollisionEnter(Collision collision)
    {
        col = collision.gameObject.GetComponent<Renderer>().material.color;
        collision.gameObject.GetComponent<Renderer>().material.color = Color.black;
        if (collision.gameObject.tag == "blue")
        {
            mat.color = Color.blue;
        }
        else if(collision.gameObject.tag == "yellow")
        {
            mat.color = Color.yellow;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.GetComponent<Renderer>().material.color = col;
    }
}
