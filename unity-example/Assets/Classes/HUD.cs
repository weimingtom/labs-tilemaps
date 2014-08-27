﻿using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {
    
    }
    
    // Update is called once per frame
    void Update ()
    {

    }

    void OnGUI ()
    {
        // TODO: update for Unity 4.6 beta GUI
        // Make a background box
        GUI.Box (new Rect (10, 10, 160, 90), "Menu");
        
        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button (new Rect (20, 40, 120, 20), "Smooth Terrain")) {
            Debug.Log ("change user mode to terrain[smoothing]");
        }
        
        // Make the second button.
        if (GUI.Button (new Rect (20, 70, 120, 20), "Place Obstruction")) {
            Debug.Log ("change user mode to place[wall]");
        }
    }
}
