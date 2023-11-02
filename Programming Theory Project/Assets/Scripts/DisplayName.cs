using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayName : MonoBehaviour
{
    [SerializeField] TMP_Text m_Text;
    void Start()
    {
        m_Text.text = "Hello " + MainManager.Instance.playerName;
    }

}
