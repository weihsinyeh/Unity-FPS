using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndGameDisplay : MonoBehaviour
{
    static float accuracy;
    static int score;
    public Text EndGameText;
    static private string result;
    public Text Rank;
    static string ranktext;
    static GameObject access;
    void Start()
    {
        accuracy = Accuracy.accuracy;
        score = Score.score;
        result = "<" + UserData.current_player.username + ">\nScore : " + score.ToString() + "\nAccuracy : " + accuracy.ToString();
        Check();
        EndGameText.text = result;
        Rank.text = ranktext;
        Debug.Log("JJSdlf" + ranktext);
    }

    static void Check()
    {
        int index = 0;
        switch (ModeSelect.mode_get)
        {
            case 1:
                {
                    switch (ClassSelect.class_choice)
                    {
                        case 1:
                            {
                                index = 0;
                                break;
                            }
                        case 2:
                            {
                                index = 1;
                                break;
                            }
                        case 3:
                            {
                                index = 2;
                                break;
                            }
                    }
                    break;
                }
            case 2:
                {
                    switch (ClassSelect.class_choice)
                    {
                        case 1:
                            {
                                index = 3;
                                break;
                            }
                        case 2:
                            {
                                index = 4;
                                break;
                            }
                        case 3:
                            {
                                index = 5;
                                break;
                            }
                    }
                    break;
                }
            case 3:
                {
                    index = 6;
                    break;
                }
            case 4:
                {
                    index = 7;
                    break;
                }
            case 5:
                {
                    index = 8;
                    break;
                }
            case 6:
                {
                    index = 9;
                    break;
                }
            default:
                {
                    index = 0;
                    break;
                }
        }
        if (UserData.get_score(index) < score)
        {
            UserData.set_accuracy(accuracy,index);
            UserData.set_score(score, index);
            Writedata.rewrite();
            result += "\n¯}¬ö¿ý";
        }
        rankdisplay(index);
    }
    static public void rankdisplay(int index)
    {
        user_data[] rank_mode = new user_data[ReadData.number_of_players];
        user_data temp;
        for (int i = 0; i < ReadData.users.Count; i++)
        {
            rank_mode[i] = ReadData.users[i];
        }
        for (int i = 1; i < ReadData.users.Count; i++)
        {
            for (int j = 0; j < ReadData.users.Count - 1; j++)
            {
                if (rank_mode[j].mode_score[index] < rank_mode[j + 1].mode_score[index])
                {
                    temp = rank_mode[j];
                    rank_mode[j] = rank_mode[j + 1];
                    rank_mode[j + 1] = temp;
                }
            }
        }
        ranktext = "Rank";
        for (int i = 0; i < ReadData.users.Count; i++)
        {
            ranktext += "\n<" + rank_mode[i].username + ">\nScore : " + rank_mode[i].mode_score[index].ToString() + "\nAccuracy : " + rank_mode[i].mode_accuracy[index].ToString() + "\n";
        }
        Debug.Log("HI");
        Debug.Log(ranktext);
    }
}
