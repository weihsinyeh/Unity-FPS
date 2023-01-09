//¸­±©ªY12/31
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Class_display : MonoBehaviour
{
    public Text user_information,easytext, hardtext,experttext;
    public Button easy, hard, expert;
    public Image easy_lock, hard_lock, expert_lock;
    private int level;
    // Start is called before the first frame update
    void Start()
    {
        
        user_information.text = "Player : " + UserData.get_username()
                               + "\nAccount : " + UserData.get_useremail()
                               + "\nLevel:" + UserData.get_userlevel()
                               + "\nRank:" + UserData.get_userrank();
        level = UserData.get_userlevel();
        if(level < 10)
        {
            easy_lock.gameObject.SetActive(false);
            easy.enabled = true;
            hard_lock.gameObject.SetActive(false);
            hard.enabled = true;
            expert_lock.gameObject.SetActive(true);
            expert.enabled = false;
        }
        else
        {
            easy_lock.gameObject.SetActive(false);
            easy.enabled = true;
            hard_lock.gameObject.SetActive(false);
            hard.enabled = true;
            expert_lock.gameObject.SetActive(false);
            expert.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch(ModeSelect.mode_get)
        {
            case 1:
                {
                    easytext.text = "Normal Mode";
                    hardtext.text = "Speed Mode";
                    experttext.text = "Precision Mode";
                    //easy.GetComponent<Text>().text = "Normal Mode";
                    //hard.GetComponent<Text>().text = "Speed Mode";
                    //expert.GetComponent<Text>().text = "Precision Mode";
                    break;
                }
            case 6:
                {
                    easytext.text = "Normal Mode";
                    hardtext.text = "Hard Mode";
                    experttext.text = "Expert Mode";
                    //easy.GetComponent<Text>().text = "Normal Mode";
                    //hard.GetComponent<Text>().text = "Hard Mode";
                    //expert.GetComponent<Text>().text = "Expert Mode";
                    break;
                }
        }
    }
}
