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
                    if(!GameManager.instance.GetDoor() && !GameManager.instance.GetIntent())
                        GameManager.instance.ChangeBarrera();
                    break;
                case "puerta":
                    if (GameManager.instance.GetTanca())
                        GameManager.instance.ChangePuerta();
                    else
                        GameManager.instance.SetIntent(true);
                    break;
            }
        }
    }
}
