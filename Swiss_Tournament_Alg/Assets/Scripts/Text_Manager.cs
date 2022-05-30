using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_Manager : MonoBehaviour
{
    public TextMeshProUGUI teamListText;    // text that displays all team numbers

    public void displayAllTeams(Team_Template[] teamList)
    {
        string t = "";

        foreach (Team_Template team in teamList)
        {
            t += team.teamNum + " ";
        }
        teamListText.text = t;
    }
}
