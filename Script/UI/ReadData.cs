using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
public struct user_data
{
    public int rank { get; set; }
    public string username { get; set; }
    public int level { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public int experience { get; set; }
    public int [] mode_score;
    public float [] mode_accuracy { get; set; }
}
public class ReadData : MonoBehaviour
{
    public TextAsset TxtFile;
    private string Usertxt;
    StreamReader reader;
    StreamWriter writer;
    static public List<user_data> users = new List<user_data>();
    static public int number_of_players = 0; 
    static int player_index;
    // Start is called before the first frame update
    void Start()
    {
        FileInfo file = new FileInfo(Application.dataPath + "/Resources/userdata.txt");
        if (file.Exists)
        {
            Read();
         
        }
    }
    public void Read()
    {
        try
        {
            reader = new StreamReader(Application.dataPath + "/Resources/userdata.txt");
            string str = reader.ReadLine();
            int j = 0;
            while (!((str = reader.ReadLine()).Contains("#")))
            {
                string[] subs = str.Split(',');
                int i = 0;
                var user_detail = new user_data();
                user_detail.mode_accuracy = new float[10];
                user_detail.mode_score = new int[10];
                foreach (var sub in subs)
                {
                    switch (i)
                    {
                        case 0:
                            user_detail.rank = int.Parse(sub);
                            break;
                        case 1:
                            user_detail.username = sub;
                            break;
                        case 2:
                            user_detail.level = int.Parse(sub);
                            break;
                        case 3:
                            user_detail.email = sub;
                            break;
                        case 4:
                            user_detail.password = sub;
                            break;
                        case 5:
                            user_detail.experience = int.Parse(sub);
                            break;
                        case 6:
                            user_detail.mode_score[0] = int.Parse(sub);
                            break;
                        case 7:
                            user_detail.mode_accuracy[0] = float.Parse(sub);
                            break;
                        case 8:
                            user_detail.mode_score[1] = int.Parse(sub);
                            break;
                        case 9:
                            user_detail.mode_accuracy[1] = float.Parse(sub);
                            break;
                        case 10:
                            user_detail.mode_score[2] = int.Parse(sub);
                            break;
                        case 11:
                            user_detail.mode_accuracy[2] = float.Parse(sub);
                            break;
                        case 12:
                            user_detail.mode_score[3] = int.Parse(sub);
                            break;
                        case 13:
                            user_detail.mode_accuracy[3] = float.Parse(sub);
                            break;
                        case 14:
                            user_detail.mode_score[4] = int.Parse(sub);
                            break;
                        case 15:
                            user_detail.mode_accuracy[4] = float.Parse(sub);
                            break;
                        case 16:
                            user_detail.mode_score[5] = int.Parse(sub);
                            break;
                        case 17:
                            user_detail.mode_accuracy[5] = float.Parse(sub);
                            break;
                        case 18:
                            user_detail.mode_score[6] = int.Parse(sub);
                            break;
                        case 19:
                            user_detail.mode_accuracy[6] = float.Parse(sub);
                            break;
                        case 20:
                            user_detail.mode_score[7] = int.Parse(sub);
                            break;
                        case 21:
                            user_detail.mode_accuracy[7] = float.Parse(sub);
                            break;
                        case 22:
                            user_detail.mode_score[8] = int.Parse(sub);
                            break;
                        case 23:
                            user_detail.mode_accuracy[8] = float.Parse(sub);
                            break;
                        case 24:
                            user_detail.mode_score[9] = int.Parse(sub);
                            break;
                        case 25:
                            user_detail.mode_accuracy[9] = float.Parse(sub);
                            break;
                    }
                    i++;
                }
                users.Add(user_detail);
                int index = users.FindIndex(x => x.username == user_detail.username);
                j++;
            }
            number_of_players = j;
         
           
            reader.Dispose();
            reader.Close();
        }
        catch
        {
        }
    }
    public string rankdisplay()
    {
        string details = string.Format("{0}\t\t{1}\t\t{2}\n", "排名", "玩家", "等級");
        for (int k = 0; k < number_of_players; k++){
            details += users[k].rank +"\t\t" + users[k].username + "\t\t"+users[k].level+"\n";
        }
        return details;
    }
    public void Write(string user_data)
    {
        FileInfo file = new FileInfo(Application.dataPath + "/userdata.txt");
        if (!file.Exists)
            writer = file.CreateText();
        
        else
            writer = file.AppendText();
        
        writer.WriteLine(user_data);
        writer.Flush();
        writer.Dispose();
        writer.Close();
    }
    static public int getPlayerIndex(){
        return player_index;
    }
    public bool Find(string email){
        int i=0;
        while (i<number_of_players){
            if ((string.Compare(users[i].email, email) == 0)){
                player_index = i;
                return true;
            }
            i++;
        }
        return false;

    }
    public bool Check(string email,string password) //Check有沒有這個玩家
    {
        if (Find(email)){
            if ((string.Compare(users[getPlayerIndex()].password, password) == 0))
                return true;
            
            else
                return false;
            
        }
        else   
            return false;
    }
    public user_data Get(int index)
    {
        return users[index];
    }
}
