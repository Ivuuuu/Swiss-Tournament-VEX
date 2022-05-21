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
}
