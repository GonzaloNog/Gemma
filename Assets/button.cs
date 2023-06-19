using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public string comand;
    private bool mouse = false;
    private void OnMouseEnter()
    {
        mouse = true;
    }
    private void OnMouseExit()
    {
        mouse = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && mouse)
        {
            switch (comand)
            {
                case "barrera":
                    GameManager.instance.ChangeBarrera();
                    break;
                case "puerta":
                    GameManager.instance.ChangePuerta();
                    break;
            }
        }
    }
}
