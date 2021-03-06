﻿using UnityEngine;
using System.Collections;

public class OptionsMenu : MonoBehaviour 
{
	public GUIStyle buttonTexture;


    void OnGUI()
    {
        const int buttonWidth = 256;
        const int buttonHeight = 60;

        //Draw StartGame Button
		if (GUI.Button(
			new Rect(   Screen.width / 4 - (buttonWidth / 2),
		         8 * (Screen.height / 9) - (buttonHeight / 2),
		         buttonWidth, buttonHeight), "Back to Menu", buttonTexture))
		{
			//Button Do Method
			Application.LoadLevel("MainMenu");
		}
		/*
		if (GUI.Button(
			new Rect(   Screen.width / 4 - (buttonWidth / 2),
		         6 * (Screen.height / 9) - (buttonHeight / 2),
		         buttonWidth, buttonHeight), "Music", buttonTexture))
		{
			//Button Do Method

		}

        //Draw Options Button
		if (GUI.Button(
			new Rect(   3 * (Screen.width / 4) - (buttonWidth / 2),
		         6 * (Screen.height / 9) - (buttonHeight / 2),
		         buttonWidth, buttonHeight), "SFX", buttonTexture))
		{
			//Button Do Method

		}

       /* //Draw Exit Button
        if (GUI.Button(
                new Rect(   3 * (Screen.width / 4) - (buttonWidth / 2),
                            8 * (Screen.height / 9) - (buttonHeight / 2),
                            buttonWidth, buttonHeight), "Exit Game"))
        {
            //Button Do Method
            Application.Quit();
        }*/
    }
}
