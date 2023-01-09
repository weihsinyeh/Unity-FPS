using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Display : MonoBehaviour
{
    public Text user_information;
    public Text rank;
    // Start is called before the first frame update
    void Start()
    {
        user_information.text = "Welcome" + UserData.get_username()
                               + "\nLevel:" + UserData.get_userlevel()
                               + "\nRank:" + UserData.get_userrank();
        rank.text = "Rank:\n" + UserData.get_rankdetail();
        Debug.Log("342342");
        Debug.Log("sdfsdf"+UserData.get_rankdetail());
    }
}
