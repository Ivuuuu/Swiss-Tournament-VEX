using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_Manager : MonoBehaviour
{
    // VARIABLES
    public TextMeshProUGUI teamListText;    // text that displays all team numbers
    public TextMeshProUGUI roundNum;
    public TextMeshProUGUI matchNum;

    public TextMeshProUGUI redAlliance;
    public TextMeshProUGUI blueAlliance;

    public void displayAllTeams(Team_Template[] teamList)
    {
        string t = "";

        foreach (Team_Template team in teamList)
        {
            t += team.teamNum + " ";
        }
        teamListText.text = t;
    }

    public void updateMatchText(string red1, string red2, string blue1, string blue2)   // updates text on per match basis (like alliances)
    {
        redAlliance.text = "Red Alliance" + "\n" + red1 + "\n" + red2;
        blueAlliance.text = "Blue Alliance" + "\n" + blue1 + "\n" + blue2;
    }

    public void updateMatchNum(int n)
    {
        matchNum.text = "Match# " + n;
    }

    public void updateRoundNum(int n)
    {
        roundNum.text = "Round# " + n;
    }
}
