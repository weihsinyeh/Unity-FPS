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
                               "�D�n�b�V�m�g����b���������u�P�﨤�u�W���g��\n" +
                               "******************************\n" +
                               "�C������:\n" +
                               "Normal Mode:\n" +
                               "���T���y�A�I��ղy��N�|�����C������|���ܦ�m�C\n" +
                               "******************************\n" +
                               "Speed Mode:  (��level��10����)\n" +
                               "���T���y�A��y�Ӥ[�S���Q�g���A�y���j�p�|�v��" +
                               "�p�A�ܱo�V���g��\n"+
                                "******************************\n" +
                               "Precision Mode: (��level��20����)\n" +
                               "���T���y�A�y���j�p���T�w\n"+
                               "******************************";
        }
        else if (mouseX < mode2.transform.position.x + 100 &&
            mouseX > mode2.transform.position.x - 100 &&
            mouseY < mode2.transform.position.y + 25 &&
            mouseY > mode2.transform.position.y - 25)
        {
                mode_detail.text = "SwitchTrack:   level>10����\n" +
                                   "�C������:\n" +
                                   "�����ŤT�y�A���y�I���|�����ε����C���A" +
                                   "�x�y�I���L�ġA���y�I���i�H�o��\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "���T���y�A���O�������šA���p�C���ɶ��A" +
                                   "�I��y��N�|�����C������|���ܦ�m�C\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (��level��10����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�I" +
                                   "��y��N�|�����C\n" +
                                   "******************************\n" +
                                   "Expert Easy: (��level��20����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�y" +
                                   "�|���ʡA�I��y��N�|�����C\n" +
                                   "******************************";
        }
        else if (mouseX < mode3.transform.position.x + 100 &&
            mouseX > mode3.transform.position.x - 100 &&
            mouseY < mode3.transform.position.y + 25 &&
            mouseY > mode3.transform.position.y - 25)
        {
                mode_detail.text = "HeadShot:   level>20����\n" +
                                   "�C������:\n" +
                                   "�����ŤT�y�A���y�I���|�����ε����C���A" +
                                   "�x�y�I���L�ġA���y�I���i�H�o��\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "���T���y�A���O�������šA���p�C���ɶ��A" +
                                   "�I��y��N�|�����C������|���ܦ�m�C\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (��level��10����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�I" +
                                   "��y��N�|�����C\n" +
                                   "******************************\n" +
                                   "Expert Easy: (��level��20����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�y" +
                                   "�|���ʡA�I��y��N�|�����C\n" +
                                   "******************************";
        }
        else if (mouseX < mode4.transform.position.x + 100 &&
            mouseX > mode4.transform.position.x - 100 &&
            mouseY < mode4.transform.position.y + 25 &&
            mouseY > mode4.transform.position.y - 25)
        {
                mode_detail.text = "���߿߼Ҧ�:   level>20����\n" +
                                   "�C������:\n" +
                                   "�����ŤT�y�A���y�I���|�����ε����C���A" +
                                   "�x�y�I���L�ġA���y�I���i�H�o��\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "���T���y�A���O�������šA���p�C���ɶ��A" +
                                   "�I��y��N�|�����C������|���ܦ�m�C\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (��level��10����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�I" +
                                   "��y��N�|�����C\n" +
                                   "******************************\n" +
                                   "Expert Easy: (��level��20����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�y" +
                                   "�|���ʡA�I��y��N�|�����C\n" +
                                   "******************************";
        }
        else if (mouseX < mode5.transform.position.x + 100 &&
            mouseX > mode5.transform.position.x - 100 &&
            mouseY < mode5.transform.position.y + 25 &&
            mouseY > mode5.transform.position.y - 25)
        {
                mode_detail.text = "�k�]�Ҧ�:   level>20����  \n" +
                                   "�C������:\n" +
                                   "�����ŤT�y�A���y�I���|�����ε����C���A" +
                                   "�x�y�I���L�ġA���y�I���i�H�o��\n" +
                                   "******************************\n" +
                                   "Class Easy:\n" +
                                   "���T���y�A���O�������šA���p�C���ɶ��A" +
                                   "�I��y��N�|�����C������|���ܦ�m�C\n" +
                                   "******************************\n" +
                                   "Hard Easy:   (��level��10����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�I" +
                                   "��y��N�|�����C\n" +
                                   "******************************\n" +
                                   "Expert Easy: (��level��20����)\n" +
                                   "���T���y�A���O�������šA�p�C���ɶ��A�y" +
                                   "�|���ʡA�I��y��N�|�����C\n" +
                                   "******************************";
        }
        else if (mouseX < mode6.transform.position.x + 100 &&
            mouseX > mode6.transform.position.x - 100 &&
            mouseY < mode6.transform.position.y + 25 &&
            mouseY > mode6.transform.position.y - 25)
        {
                mode_detail.text = "�ĤH�ͭx�Ҧ�:   level>20����\n" +
                                   "�C������:\n" +
                                   "��(�ĤH)��(�B��)��(����)�T�y�A���y�I���|�[��" +
                                   "�x�y�I���L�ġA���y�I���|�����A�y������|�H���ܤ�\n" +
                                   "**************************************************\n" +
                                   "Normal Easy:\n" +
                                   "�I��y��N�|�����C������|���ܦ�m�C\n" +
                                   "**************************************************\n" +
                                   "Hard Easy:   (��level��10����)\n" +
                                   "���T���y�A���I��B�ͩΤ��߷|�X�{�\�h���ĤH�V�õ�ť�C\n" +
                                   "**************************************************\n" +
                                   "Expert Easy: (��level��20����)\n" +
                                   "���T���y�A���I��B�ͩΤ��߷|�X�{�\�h���ĤH�V�õ�ť,���T���y�|����\n" +
                                   "******************************";
            
        }
        else
        {
            mode_detail.text = "";
        }
    }
}
