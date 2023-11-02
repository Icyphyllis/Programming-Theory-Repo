using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    MeshFilter _shape;
    Color _color;
    string _displayText;
    public TMP_Text tmptext;

    public MeshFilter shape { get { return gameObject.GetComponent<MeshFilter>(); } set { _shape = value; } }
    public Color color {  get { return gameObject.GetComponent<MeshRenderer>().material.color; } set { _color = value; } }
    public string displayText { get { return _displayText; } set { _displayText = value; } }
    
    public abstract void DisplayText();
    public abstract void DisplayText(string text);

    private void OnMouseDown()
    {
        DisplayText();
    }
}
