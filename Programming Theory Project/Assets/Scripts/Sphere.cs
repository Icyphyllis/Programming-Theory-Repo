using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    void Start()
    {
        displayText = "I matter";
    }

    public override void DisplayText()
    {
        displayText = "Bonjour, I am a " + color + " " + shape;
        tmptext.text = displayText;
        tmptext.color = color;
    }

    public override void DisplayText(string text)
    {
        tmptext.text = text;
    }
}
