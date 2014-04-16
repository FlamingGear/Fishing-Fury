using UnityEngine;
using System.Collections;

public class CompanySummaryMenu : MonoBehaviour 
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
                            buttonWidth, buttonHeight), "Upgrade Boat", buttonTexture))
        {
            //Button Do Method
            Application.LoadLevel("UpgradesScreen");
        }

        //Draw HighScores Button
        if (GUI.Button(
                new Rect(  3 * (Screen.width) / 4 - (buttonWidth / 2),
                           6 * (Screen.height / 9) - (buttonHeight / 2),
                            buttonWidth, buttonHeight), "Go Fishing", buttonTexture))
        {
            //Button Do Method
            Application.LoadLevel("Game");
        }

         //Draw Options Button
        if (GUI.Button(
                new Rect(   Screen.width / 4 - (buttonWidth / 2),
                            8 * (Screen.height / 9) - (buttonHeight / 2),
                            buttonWidth, buttonHeight), "Check Fish Stocks", buttonTexture))
        {
            //Button Do Method
            Application.LoadLevel("FishStocks");
        }


        //Draw Exit Button
        if (GUI.Button(
                new Rect(   3 * (Screen.width / 4) - (buttonWidth / 2),
                            8 * (Screen.height / 9) - (buttonHeight / 2),
                            buttonWidth, buttonHeight), "Main Menu", buttonTexture))
        {
            //Button Do Method
			Application.LoadLevel("MainMenu");
        }
    }
}
