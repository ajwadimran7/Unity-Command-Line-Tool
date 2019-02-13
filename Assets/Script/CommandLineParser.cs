using UnityEngine;
using System;

public class CommandLineParser : MonoBehaviour {

    void Awake ()
    {
        Debug.Log("App Started.");
        string[] args = Environment.GetCommandLineArgs();
        foreach (string arg in args) {
            Debug.Log(arg);
        }
        Debug.Log("Quitting app.");
        Application.Quit();
    }
}
