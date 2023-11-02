using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    void Start()
    {
        displayText = "Click here too";
    }

    public override void DisplayText()
    {
        displayText = "Heya, I am a " + color + " " + shape;
        tmptext.text = displayText;
        tmptext.color = color;
    }

    public override void DisplayText(string text)
    {
        tmptext.text = text;
    }
}
