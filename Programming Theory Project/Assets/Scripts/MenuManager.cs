using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    [SerializeField] TMP_InputField nameInput;

    public void StartGame()
    {
        MainManager.Instance.playerName = (nameInput != null && !string.IsNullOrEmpty(nameInput.text)) ? nameInput.text : "Stupid";
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
    }
}
