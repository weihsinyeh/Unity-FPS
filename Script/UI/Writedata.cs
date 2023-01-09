using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Writedata : MonoBehaviour, IPointerClickHandler
{
    public InputField Email, UserName, Password;
    public TextAsset TxtFile;
    private string Usertxt;
    StreamReader reader;
    StreamWriter writer;
    public List<user_data> users = new List<user_data>();
    int player_index;
    static user_data newuser;
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData e)
    {
        newuser.email = Email.text;
        newuser.username = UserName.text;
        newuser.rank = ReadData.users.Count + 1;
        newuser.experience = 0;
        newuser.password = Password.text;
        newuser.level = 30;
        
        for(int i = 0; i < 10; i++)
        {
            newuser.mode_accuracy[i] = 0;
            newuser.mode_score[i] = 0;
        }
        ReadData.users.Add(newuser);
        sortRank(ReadData.users);
        submitWrite();
    }
    public void Write(string user_data)
    {
        FileInfo file = new FileInfo(Application.dataPath + "/Resources/userdata.txt");

        writer = file.CreateText();
        writer.WriteLine(user_data);
        Debug.Log("寫進去了");
        writer.Flush();
        writer.Dispose();
        writer.Close();
    }
    public void submitWrite()
    {
        string user_data = "排名,玩家,等級,帳號,密碼,經驗值\n";
        for(int i=0;i< ReadData.users.Count; i++)
        {
            user_data += ReadData.users[i].rank + "," + ReadData.users[i].username + "," + ReadData.users[i].level + "," + ReadData.users[i].email + "," + ReadData.users[i].password + "," + ReadData.users[i].experience +"\n";
        }
        user_data += "#";
        Debug.Log(user_data);
        Write(user_data);
    }
    static public void sortRank(List<user_data> users)
    {
        user_data temp;
        for(int i = 1; i < users.Count; i++)
        {
            for(int j = 0; j < users.Count - 1; j++)
            {
                if (users[j].level < users[j + 1].level)
                {
                    temp = users[j];
                    users[j] = users[j + 1];
                    users[j + 1] = temp;
                }
            }
        }
        for(int i = 0; i < users.Count; i++)
        {
            temp = users[i];
            temp.rank = i + 1;
            users[i] = temp;
        }
    }
    static public void rewrite()
    {
        ReadData.users[ReadData.getPlayerIndex()] = UserData.get_user();
        Debug.Log(ReadData.users[ReadData.getPlayerIndex()].username);
    }
}
