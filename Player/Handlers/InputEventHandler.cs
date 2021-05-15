using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEventHandler
{
    static System.Action<char> keyboardCharPressed;
    static System.Action<MovementKey> movementKeyPressed;
    static System.Action<MovementKey> movementKeyUnPressed;
    static System.Action<float> mouseLeftRightPosition;
    static System.Action<MouseInput> mouseClicked;
    static System.Action<MouseInput> mouseUnClicked;

    public InputEventHandler()
    {

    }

    public void InvokeKeyboardCharPressed(char button)
    {
        if (keyboardCharPressed != null) { keyboardCharPressed.Invoke(button); }
    }

    public void InvokeMovementKeyPressed(MovementKey movementKey)
    {
        if (movementKeyPressed != null) { movementKeyPressed.Invoke(movementKey); }
    }

    public void InvokeMovementKeyUnPressed(MovementKey movementKey)
    {
        if (movementKeyUnPressed != null) { movementKeyUnPressed.Invoke(movementKey); }
    }

    public void InvokeMouseLeftRightPosition(float value)
    {
        if(mouseLeftRightPosition != null) { mouseLeftRightPosition.Invoke(value); }
    }

    //------------------------------------------------------------------------//

    public static void RegisterToKeyboardCharPressed(System.Action<char> action)
    {
        keyboardCharPressed += action;
    }

    public static void RegisterToMovementKeyPressed(System.Action<MovementKey> action)
    {
        movementKeyPressed += action;
    }

    public static void RegisterToMovementKeyUnPressed(System.Action<MovementKey> action)
    {
        movementKeyUnPressed += action;
    }

    public static void RegisterToMouseLeftRightPosition(System.Action<float> action)
    {
        mouseLeftRightPosition += action;
    }

    //---------------------------------------------------------------------------------//

    public static void UnRegisterToKeyboardCharPressed(System.Action<char> action)
    {
        keyboardCharPressed -= action;
    }

    public static void UnRegisterToMovementKeyPressed(System.Action<MovementKey> action)
    {
        movementKeyPressed -= action;
    }

    public static void UnRegisterToMovementKeyUnPressed(System.Action<MovementKey> action)
    {
        movementKeyUnPressed -= action;
    }

    public static void UnRegisterToMouseLeftRightPosition(System.Action<float> action)
    {
        mouseLeftRightPosition -= action;
    }

    //--------------------------------------------------------------------------------//
    //================================================================================//
}
