using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ModeDetail : MonoBehaviour
{
    public Text mode_detail;
    public Text user_information;
    public float mouseSensitivity = 200f;
    public Image mode1_lock, mode2_lock, mode3_lock, mode4_lock,mode5_lock,mode6_lock;
    public Button mode1, mode2, mode3, mode4,mode5,mode6;
    private int level;
    void Start()
    {
        user_information.text = "Player : " + UserData.get_username()
                               +"\nAccount : " + UserData.get_useremail()
                               +"\nLevel : " + UserData.get_userlevel()
                               +"\nRank : " + UserData.get_userrank()
                               +"\nExperience : " + UserData.get_userexperience(); 
        level = (UserData.get_userlevel());
        if (level < 5)
        {
            mode1_lock.gameObject.SetActive(false);
            mode1.enabled = true;
            mode2_lock.gameObject.SetActive(true);
            mode2.enabled = false;
            mode3_lock.gameObject.SetActive(true);
            mode3.enabled = false;
            mode4_lock.gameObject.SetActive(true);
            mode4.enabled = false;
            mode5_lock.gameObject.SetActive(true);
            mode5.enabled = false;
            mode6_lock.gameObject.SetActive(true);
            mode6.enabled = false;
        }
        else if (level < 20)
        {
            mode1_lock.gameObject.SetActive(false);
            mode1.enabled = true;
            mode2_lock.gameObject.SetActive(false);
            mode2.enabled = true;
            mode3_lock.gameObject.SetActive(true);
            mode3.enabled = false;
            mode4_lock.gameObject.SetActive(true);
            mode4.enabled = false;
            mode5_lock.gameObject.SetActive(true);
            mode5.enabled = false;
            mode6_lock.gameObject.SetActive(true);
            mode6.enabled = false;
        }
        else
        {
            mode1_lock.gameObject.SetActive(false);
            mode1.enabled = true;
            mode2_lock.gameObject.SetActive(false);
            mode2.enabled = true;
            mode3_lock.gameObject.SetActive(false);
            mode3.enabled = true;
            mode4_lock.gameObject.SetActive(false);
            mode4.enabled = true;
            mode5_lock.gameObject.SetActive(false);
            mode5.enabled = true;
            mode6_lock.gameObject.SetActive(false);
            mode6.enabled = true;
        }
    }
    void Update()
    {
        Vector2 mouse = Input.mousePosition;
        float mouseX = mouse.x;
        float mouseY = mouse.y;
        if (mouseX < mode1.transform.position.x + 100 && 
            mouseX > mode1.transform.position.x - 100 &&
            mouseY < mode1.transform.position.y + 25&&
            mouseY > mode1.transform.position.y - 25)
        {
            mode_detail.text = "GridShot:\n" +
                               "主要在訓練射擊手在水平垂直線與對角線上的射擊\n" +
                               "******************************\n" +
                               "遊戲說明:\n" +
                               "Normal Mode:\n" +
                               "有三顆球，點到白球後就會消失。消失後會改變位置。\n" +
                               "******************************\n" +
                               "Speed Mode:  (當level到10解鎖)\n" +
                               "有三顆球，當球太久沒有被射擊，球的大小會逐變" +
                               "小，變得越難射擊\n"+
                                "******************************\n" +
                               "Precision Mode: (當level到20解鎖)\n" +
                               "有三顆球，球的大小不固定\n"+
                               "******************************";
        }
        else if (mouseX < mode2.transform.position.x + 100 &&
            mouseX > mode2.transform.position.x - 100 &&
            mouseY < mode2.transform.position.y + 25 &&
            mouseY > mode2.transform.position.y - 25)
        {
                mode_detail.text = "SwitchTrack:   level>10解鎖\n" +
                                   "遊戲說明:\n" +
                                   "紅黃藍三球，紅球點擊會扣分或結束遊戲，" +
                                   "籃球點擊無效，黃球點擊可以得分\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "有三顆球，分別為紅黃藍，不計遊戲時間，" +
                                   "點到球後就會消失。消失後會改變位置。\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (當level到10解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，點" +
                                   "到球後就會消失。\n" +
                                   "******************************\n" +
                                   "Expert Easy: (當level到20解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，球" +
                                   "會移動，點到球後就會消失。\n" +
                                   "******************************";
        }
        else if (mouseX < mode3.transform.position.x + 100 &&
            mouseX > mode3.transform.position.x - 100 &&
            mouseY < mode3.transform.position.y + 25 &&
            mouseY > mode3.transform.position.y - 25)
        {
                mode_detail.text = "HeadShot:   level>20解鎖\n" +
                                   "遊戲說明:\n" +
                                   "紅黃藍三球，紅球點擊會扣分或結束遊戲，" +
                                   "籃球點擊無效，黃球點擊可以得分\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "有三顆球，分別為紅黃藍，不計遊戲時間，" +
                                   "點到球後就會消失。消失後會改變位置。\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (當level到10解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，點" +
                                   "到球後就會消失。\n" +
                                   "******************************\n" +
                                   "Expert Easy: (當level到20解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，球" +
                                   "會移動，點到球後就會消失。\n" +
                                   "******************************";
        }
        else if (mouseX < mode4.transform.position.x + 100 &&
            mouseX > mode4.transform.position.x - 100 &&
            mouseY < mode4.transform.position.y + 25 &&
            mouseY > mode4.transform.position.y - 25)
        {
                mode_detail.text = "躲貓貓模式:   level>20解鎖\n" +
                                   "遊戲說明:\n" +
                                   "紅黃藍三球，紅球點擊會扣分或結束遊戲，" +
                                   "籃球點擊無效，黃球點擊可以得分\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "有三顆球，分別為紅黃藍，不計遊戲時間，" +
                                   "點到球後就會消失。消失後會改變位置。\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (當level到10解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，點" +
                                   "到球後就會消失。\n" +
                                   "******************************\n" +
                                   "Expert Easy: (當level到20解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，球" +
                                   "會移動，點到球後就會消失。\n" +
                                   "******************************";
        }
        else if (mouseX < mode5.transform.position.x + 100 &&
            mouseX > mode5.transform.position.x - 100 &&
            mouseY < mode5.transform.position.y + 25 &&
            mouseY > mode5.transform.position.y - 25)
        {
                mode_detail.text = "逃跑模式:   level>20解鎖  \n" +
                                   "遊戲說明:\n" +
                                   "紅黃藍三球，紅球點擊會扣分或結束遊戲，" +
                                   "籃球點擊無效，黃球點擊可以得分\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "有三顆球，分別為紅黃藍，不計遊戲時間，" +
                                   "點到球後就會消失。消失後會改變位置。\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (當level到10解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，點" +
                                   "到球後就會消失。\n" +
                                   "******************************\n" +
                                   "Expert Easy: (當level到20解鎖)\n" +
                                   "有三顆球，分別為紅黃藍，計遊戲時間，球" +
                                   "會移動，點到球後就會消失。\n" +
                                   "******************************";
        }
        else if (mouseX < mode6.transform.position.x + 100 &&
            mouseX > mode6.transform.position.x - 100 &&
            mouseY < mode6.transform.position.y + 25 &&
            mouseY > mode6.transform.position.y - 25)
        {
                mode_detail.text = "敵人友軍模式:   level>20解鎖\n" +
                                   "遊戲說明:\n" +
                                   "紅(敵人)黃(朋友)藍(中立)三球，紅球點擊會加分" +
                                   "籃球點擊無效，黃球點擊會扣分，球的角色會隨時變化\n" +
                                   "**************************************************\n" +
                                   "Normal Easy:\n" +
                                   "點到球後就會消失。消失後會改變位置。\n" +
                                   "**************************************************\n" +
                                   "Hard Easy:   (當level到10解鎖)\n" +
                                   "有三顆球，當點到朋友或中立會出現許多假敵人混亂視聽。\n" +
                                   "**************************************************\n" +
                                   "Expert Easy: (當level到20解鎖)\n" +
                                   "有三顆球，當點到朋友或中立會出現許多假敵人混亂視聽,有三顆球會移動\n" +
                                   "******************************";
            
        }
        else
        {
            mode_detail.text = "";
        }
    }
}
