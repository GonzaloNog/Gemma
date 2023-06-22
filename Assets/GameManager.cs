using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private bool barrera;
    private bool puerta;
    private bool intent;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }
    void Start()
    {
        barrera = false;
        puerta = false;
        intent = false;
    }
    
    public void ChangeBarrera()
    {
        barrera = !barrera;
        Debug.Log("Barrera " + barrera);
    }
    public void ChangePuerta()
    {
        puerta = !puerta;
        Debug.Log("puerta " + puerta);
    }


    public bool GetTanca()
    {
        return barrera;
    }
    public bool GetDoor()
    {
        return puerta;
    }

    public void SetIntent(bool _intent)
    {
        intent = _intent;
    }
    public bool GetIntent()
    {
        return intent;
    }
}
