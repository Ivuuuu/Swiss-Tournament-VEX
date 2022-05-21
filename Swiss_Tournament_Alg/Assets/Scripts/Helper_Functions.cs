using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helper_Functions
{
    public static void dumpTeamList(Team_Template[] teamList)
    {
        for (int i = 0; i < teamList.Length; i++)
        {
            Debug.Log(teamList[i].teamNum);
        }
    }

    public static List<int> GenerateRandomList(int maxNum)
    {
        List<int> randomList = new List<int>();

        for (int i = 0; i < maxNum; i++)
        {
            int numToAdd = Random.Range(0, maxNum);
            while (!randomList.Contains(numToAdd))
            {
                numToAdd = Random.Range(0, maxNum);
            }
            randomList.Add(numToAdd);
        }
        return randomList;
    }
}
