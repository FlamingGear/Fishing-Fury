using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour 
{
	public GUIStyle buttonTexture;

    void OnGUI()
    {
        const int buttonWidth = 256;
        const int buttonHeight = 60;

        //Draw StartGame Button
        if (GUI.Button(
                new Rect(   Screen.width / 4 - (buttonWidth / 2),
                            6 * (Screen.height / 9) - (buttonHeight / 2),
		         buttonWidth, buttonHeight), "Play Game", buttonTexture))
        {
            //Button Do Method
            Application.LoadLevel("CompanySummary");
        }

        //Draw HighScores Button
        if (GUI.Button(
                new Rect(   Screen.width / 4 - (buttonWidth / 2),
                            8 * (Screen.height / 9) - (buttonHeight / 2),
		         buttonWidth, buttonHeight), "High Scores", buttonTexture))
		{
			//Button Do Method
            Application.LoadLevel("HighScores");
        }

        //Draw Options Button
        if (GUI.Button(
                new Rect(   3 * (Screen.width / 4) - (buttonWidth / 2),
                            6 * (Screen.height / 9) - (buttonHeight / 2),
		         buttonWidth, buttonHeight), "Options", buttonTexture))
		{
			//Button Do Method
            Application.LoadLevel("Options");
        }

        //Draw Exit Button
        if (GUI.Button(
                new Rect(   3 * (Screen.width / 4) - (buttonWidth / 2),
                            8 * (Screen.height / 9) - (buttonHeight / 2),
		         buttonWidth, buttonHeight), "Exit Game", buttonTexture))
		{
			//Button Do Method
            Application.Quit();
        }
    }
}
