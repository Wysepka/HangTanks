using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharExtension 
{
    public static char ConvertToCapital(char smallLetter)
    {
        char capital = (char)((int)smallLetter + 32);
        return capital;
    }
}
