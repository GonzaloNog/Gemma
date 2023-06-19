using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private bool barrera;
    private bool puerta;

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
    }
    
    public void ChangeBarrera()
    {
        barrera = !barrera;
        Debug.Log("Barrera");
    }
    public void ChangePuerta()
    {
        puerta = !puerta;
        Debug.Log("puerta");
    }
}
