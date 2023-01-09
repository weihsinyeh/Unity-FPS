using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    private string email, password;
    static public user_data current_player;
    static string detail;
    static string username;
    static public void set_user(user_data player)
    {
        current_player = player;
    }

    static public user_data get_user()
    {
        return current_player;
    }
    static public void set_rankdetail(string now_detail)
    {
        detail = now_detail;//GameObject.FindObjectOfType<ReadData>().rankdisplay();
        Debug.Log("sdfsdfs" + detail);
    }
    static public string get_rankdetail()
    {
        Debug.Log("sdfsdfssdfgw44t34t3t" + detail);
        return detail;
    }
    static public string get_username()
    {
        return current_player.username;
    }
    static public int get_userlevel()
    {
        return current_player.level;
    }
    static public int get_userrank()
    {
        return current_player.rank;
    }
    static public string get_useremail()
    {
        return current_player.email;
    }
    static public int get_userexperience()
    {
        return current_player.experience;
    }

    static public void set_score(int score,int index)
    {
        current_player.mode_score[index] = score;
    }
    static public int get_score(int index)
    {
        return current_player.mode_score[index];
    }

    static public void set_accuracy(float accuracy, int index)
    {
        current_player.mode_accuracy[index] = accuracy;
    }
    static public float get_accuracy(int index)
    {
        return current_player.mode_accuracy[index];
    }
}
