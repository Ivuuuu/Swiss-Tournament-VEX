using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class Driver : MonoBehaviour
{
    // VARIABLES
    Team_Template[] teamList;   // holds all team objects
    public Text_Manager textManager;    // refrence to text manager class
    private int roundNumber = 1;
    private int matchNumber = 0;

    private int teamListPlaceHolder = -1;    // number used to navigate through the teamList array

    // the array indexes of the current teams in a match
    private int red1;
    private int red2;
    private int blue1;
    private int blue2;

    private void Start()
    {
        fillTeamArray();    // fill team array (all teams)
        textManager.displayAllTeams(teamList);
        Helper_Functions.dumpTeamList(teamList);

        generateFirstRound();
        textManager.updateRoundNum(roundNumber);
        Helper_Functions.dumpTeamList(teamList);
    }

    void fillTeamArray()    // read data from a text file, and input teamNum info
    {
        string path = "Assets/INPUT/TeamList.txt";
        List<string> fileLines = File.ReadLines(path).ToList();
        teamList = new Team_Template[fileLines.Count];

        for (int i = 0; i < fileLines.Count; i++)
        {
            teamList[i] = new Team_Template();
            teamList[i].teamNum = fileLines[i];
        }
    }

    private void generateFirstRound()    // randomly generate the first round (bc no data, random matches)
    {
        for (var i = teamList.Length - 1; i > 0; i--)
        {
            var r = Random.Range(0, i);
            var tmp = teamList[i];
            teamList[i] = teamList[r];
            teamList[r] = tmp;
        }
    }
    /************************************************************
     * Generating Matches Explained
     *  say we have teams (in order of strength): A, B, C, D
     *  to make matches as even as possible we want:
     *  red alliance: A & D
     *  blue alliance: B & C
    *************************************************************/
    public void generateMatch()    // called when the user hits a button
    {
        Debug.Log("button pressed");

        if (teamListPlaceHolder + 4 > teamList.Length - 1)  // if there are not enough teams for the next match, generate new round
        {
            Debug.Log("Matches Complete! Starting Next round...");
            return;
        }

        matchNumber++;

        red1 = teamListPlaceHolder + 1;
        blue1 = teamListPlaceHolder + 2;
        blue2 = teamListPlaceHolder + 3;
        red2 = teamListPlaceHolder + 4;
        teamListPlaceHolder += 4;

        textManager.updateMatchNum(matchNumber);
        textManager.updateMatchText(teamList[red1].teamNum, teamList[red2].teamNum, teamList[blue1].teamNum, teamList[blue2].teamNum);
    }

    // void generateSchedule
    // generate a match for each team, and then display on screen
    // sortList()
    // displayMatches()
    // take 1 & 3, them 2 & 4 to make a match

    // displayMatches()

    // void displayMatches()
    // take the list and display it
}
