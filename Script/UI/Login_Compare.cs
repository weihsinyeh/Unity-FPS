using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.IO;
using UnityEngine.UI;
public class Login_Compare : MonoBehaviour , IPointerClickHandler
{
    public int SceneIndexDestination = 0;
    private string email,password;
    public Text email_enter;
    public Text password_enter;
    public Image Incorrect;
    private bool success;
    private int unsuccessful=0;
    static public user_data player;
    GameObject data;
    static private string detail;
    // Start is called before the first frame update
    void Start()
    {
        Incorrect.gameObject.SetActive(false);
        data = GameObject.Find("Login_check");
    }
    public void OnPointerClick(PointerEventData e)
    {
        // get the current scene
        Scene scene = SceneManager.GetActiveScene();
        email = email_enter.text;
        password = password_enter.text;
        check(email, password);
    }
    public void check(string email,string password)
    {
        if (data.GetComponent<ReadData>().Check(email, password))
        {
            Incorrect.gameObject.SetActive(false);
            success = true;
            UserData.set_user(data.GetComponent<ReadData>().Get(ReadData.getPlayerIndex()));
            UserData.set_rankdetail(data.GetComponent<ReadData>().rankdisplay());
            SceneManager.LoadScene(0);
        }
        else
        {
            success = false;
            unsuccessful++;
            Incorrect.gameObject.SetActive(true);
            if(unsuccessful == 3)
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
