using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public static class Helper_Functions
{
    public static void dumpTeamList(Team_Template[] teamList)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < teamList.Length; i++)
        {
            sb.Append(teamList[i].teamNum);
            sb.AppendLine();
        }
        Debug.Log(sb.ToString());
    }
}
