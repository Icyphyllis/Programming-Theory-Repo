using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    void Start()
    {
        displayText = "Click me";
    }

    public override void DisplayText()
    {
        displayText = "Hello, I am a " + color + " " + shape;
        tmptext.text = displayText;
        tmptext.color = color;
    }

    public override void DisplayText(string text)
    {
        tmptext.text = text;
    }
}
