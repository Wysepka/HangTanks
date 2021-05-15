using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    InputEventHandler eventHandler;

    // Start is called before the first frame update
    void Start()
    {
        eventHandler = new InputEventHandler();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForKeyboardInput();

        CheckForMovementInput();

        CheckForMouseInput();
    }

    private void CheckForMouseInput()
    {
        float mousePositionValue = 0f;
        Vector2 mousePositionScreen = Input.mousePosition;

    }

    private void CheckForKeyboardInput()
    {
        CheckKeyboardFirstRow();

        CheckKeyboardSecondRow();

        CheckKeyboardThirdRow();
    }

    private void CheckForMovementInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            eventHandler.InvokeMovementKeyPressed(MovementKey.LeftArrow);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            eventHandler.InvokeMovementKeyPressed(MovementKey.RightArrow);
        }
    }

    #region KeyboardInput

    private void CheckKeyboardFirstRow()
    {
        //Keyboard First Row
        if (Input.GetKeyDown(KeyCode.Q))
        {
            eventHandler.InvokeKeyboardCharPressed('q');
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            eventHandler.InvokeKeyboardCharPressed('w');
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            eventHandler.InvokeKeyboardCharPressed('e');
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            eventHandler.InvokeKeyboardCharPressed('r');
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            eventHandler.InvokeKeyboardCharPressed('t');
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            eventHandler.InvokeKeyboardCharPressed('y');
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            eventHandler.InvokeKeyboardCharPressed('u');
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            eventHandler.InvokeKeyboardCharPressed('i');
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            eventHandler.InvokeKeyboardCharPressed('o');
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            eventHandler.InvokeKeyboardCharPressed('p');
        }
    }

    private void CheckKeyboardSecondRow()
    {
        //Keyboard Second Row
        if (Input.GetKeyDown(KeyCode.A))
        {
            eventHandler.InvokeKeyboardCharPressed('a');
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            eventHandler.InvokeKeyboardCharPressed('s');
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            eventHandler.InvokeKeyboardCharPressed('d');
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            eventHandler.InvokeKeyboardCharPressed('f');
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            eventHandler.InvokeKeyboardCharPressed('g');
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            eventHandler.InvokeKeyboardCharPressed('h');
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            eventHandler.InvokeKeyboardCharPressed('j');
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            eventHandler.InvokeKeyboardCharPressed('k');
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            eventHandler.InvokeKeyboardCharPressed('l');
        }

    }

    private void CheckKeyboardThirdRow()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            eventHandler.InvokeKeyboardCharPressed('z');
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            eventHandler.InvokeKeyboardCharPressed('x');
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            eventHandler.InvokeKeyboardCharPressed('c');
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            eventHandler.InvokeKeyboardCharPressed('v');
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            eventHandler.InvokeKeyboardCharPressed('b');
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            eventHandler.InvokeKeyboardCharPressed('n');
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            eventHandler.InvokeKeyboardCharPressed('m');
        }
    }

    #endregion
}
