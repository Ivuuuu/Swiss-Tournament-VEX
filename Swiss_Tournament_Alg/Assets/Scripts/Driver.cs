using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class Driver : MonoBehaviour
{
    // VARIABLES
    Team_Template[] teamList;   // holds all team objects

    // read data from a text file, and input information abt the teams
    void fillTeamArray()
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
    // string team name == (data from tct file)

    private void Start()
    {
        fillTeamArray();
        Helper_Functions.dumpTeamList(teamList);
    }
    // call generatefirstRound()

    // void generateSchedule
    // generate a match for each team, and then display on screen
    // sortList()
    // displayMatches()
        // take 1 & 3, them 2 & 4 to make a match

    // generateFirstRound()
    // displayMatches()

    // void displayMatches()
    // take the list and display it
}
