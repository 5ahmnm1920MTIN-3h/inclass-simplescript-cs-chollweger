﻿using UnityEngine;
using UnityEngine.UI;

public class ComputerNumbers : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text result;

    float varA;
    float varB;

    public void SetResult()
    {
        result.text = SubstractNumbers();
    }

    string SubstractNumbers()
    {
  
            varA = float.Parse(input1.text);
            varB = float.Parse(input2.text);

            string success = (varA - varB).ToString();
            return success;
        }

    public void ResetCounter()
    {
        input1.text = "";
        input2.text = "";
        result.text = "";
    }
}
