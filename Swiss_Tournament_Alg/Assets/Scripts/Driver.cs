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
            teamList[i] = new Team_Template();  // fills the team array
            teamList[i].teamNum = fileLines[i];
        }
    }

    private void Start()
    {
        fillTeamArray();
        Helper_Functions.dumpTeamList(teamList);
        generateFirstRound();
        Helper_Functions.dumpTeamList(teamList);
    }

    // randomly generate the first round (bc no data)
    private void generateFirstRound()
    {
        int maxNum = teamList.Length;
        List<int> randomList = Helper_Functions.GenerateRandomList(maxNum);

        Team_Template[] temp = teamList;
        for (int i = 0; i < maxNum; i++)
        {
            temp[i] = teamList[randomList[i]];
        }
        teamList = temp;
    }

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
