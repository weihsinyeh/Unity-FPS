using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    GameObject ball1, ball2, ball3;
    GameObject Background0,Background1,Background2,Background3,Background4;
    int score;
    public static Manager inst;
    [SerializeField] Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = -1;
        ball1 = GameObject.Find("ballPrefab_3");
        ball2 = GameObject.Find("ballPrefab_4");
        ball3 = GameObject.Find("ballPrefab_5");
        ball1.GetComponent<MeshRenderer>().material.color = new Color(255,0,137); //紅
        ball2.GetComponent<MeshRenderer>().material.color = new Color(249,255,0); //黃
        ball3.GetComponent<MeshRenderer>().material.color = new Color(0,169,255); //藍
        InvokeRepeating("timer", 1, 0.5f);
        Background0 = GameObject.Find("Background0");
        Background0.GetComponent<MeshRenderer>().material.color = Color.black;
        Background1 = GameObject.Find("Background1");
        Background1.GetComponent<MeshRenderer>().material.color = Color.black;
        Background2 = GameObject.Find("Background2");
        Background2.GetComponent<MeshRenderer>().material.color = Color.black;
        Background3 = GameObject.Find("Background3");
        Background3.GetComponent<MeshRenderer>().material.color = Color.black;
        Background4 = GameObject.Find("Background4");
        Background4.GetComponent<MeshRenderer>().material.color = Color.black;
        if (ClassSelect.class_choice == 3)
        {
            InvokeRepeating("Move", 1, 0.01f);
        }
    }
    public void Score(int property)
    {
        switch (property)
        {
            case 0:
                {
                    score++;
                    break;
                }
            case 2:
                {
                    score--;
                    break;
                }
            default:
                {
                    break;
                }

        }
        scoreText.text = "SCORE: " + score+
                         "\n紅色是敵人"+
                         "\n藍色是中立"+
                         "\n黃色是朋友";
    }
    private void Move()
    {
        ball1.transform.position = new Vector3(ball1.transform.position.x + Random.Range(-0.2f, 0.2f), ball1.transform.position.y + Random.Range(-0.2f, 0.2f), ball1.transform.position.z);
        ball2.transform.position = new Vector3(ball2.transform.position.x + Random.Range(-0.2f, 0.2f), ball2.transform.position.y + Random.Range(-0.2f, 0.2f), ball2.transform.position.z);
        ball3.transform.position = new Vector3(ball3.transform.position.x + Random.Range(-0.2f, 0.2f), ball3.transform.position.y + Random.Range(-0.2f, 0.2f), ball3.transform.position.z);
    }
    public void Awake()
    {
        inst = this;
    }
    void timer()
    {
        int change = Random.Range(0, 3);
        switch (change)
        {
            case 3:
                ball1.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137); //紅
                Property.set_property_ball3(0);
                ball2.GetComponent<MeshRenderer>().material.color = new Color(249, 255, 0); //黃
                Property.set_property_ball4(2);
                ball3.GetComponent<MeshRenderer>().material.color = new Color(0, 169, 255); //藍
                Property.set_property_ball5(1);
                break;
            case 2:
                ball1.GetComponent<MeshRenderer>().material.color = new Color(249, 255, 0); //黃
                Property.set_property_ball3(2);
                ball2.GetComponent<MeshRenderer>().material.color = new Color(0, 169, 255); //藍
                Property.set_property_ball4(1);
                ball3.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137); //紅
                Property.set_property_ball5(0);
                break;
            case 1:
                ball1.GetComponent<MeshRenderer>().material.color = new Color(0, 169, 255); //藍
                Property.set_property_ball3(1);
                ball2.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137); //紅
                Property.set_property_ball4(0);
                ball3.GetComponent<MeshRenderer>().material.color = new Color(249, 255, 0); //黃
                Property.set_property_ball5(2);
                break;
        }
    }
}
