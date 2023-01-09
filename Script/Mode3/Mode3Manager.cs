using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mode3Manager : MonoBehaviour
{
    GameObject enemy1, enemy2, enemy3;
    GameObject Background0, Background1, Background2, Background3, Background4;
    int score;
    public static Mode3Manager inst;
    [SerializeField] Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = -1;
        enemy1 = GameObject.Find("enemy2");
        enemy2 = GameObject.Find("enemy3");
        enemy3 = GameObject.Find("enemy4");
        /*enemy4 = GameObject.Find("ballPrefab_3");
        enemy5 = GameObject.Find("ballPrefab_4");
        enemy6 = GameObject.Find("ballPrefab_5");*/

        /*enemy1.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137); //¬õ
        enemy2.GetComponent<MeshRenderer>().material.color = new Color(249, 255, 0); //¶À
        enemy3.GetComponent<MeshRenderer>().material.color = new Color(0, 169, 255); //ÂÅ*/

        InvokeRepeating("timer", 1, 0.5f);
        Property.set_property_ball3(0);
        Property.set_property_ball4(1);
        Property.set_property_ball5(2);
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
        /*if (ClassSelect.class_choice == 3)
        {
            InvokeRepeating("Move", 1, 0.01f);
        }*/
    }
    public void Score(int property)
    {
        switch (property)
        {
            case 0:
                {
                    score++;
                    Debug.Log("0");
                    break;
                }
            case 1:
                {
                    score++;
                    Debug.Log("1");
                    break;
                }
            case 2:
                {
                    score++;
                    Debug.Log("2");
                    break;
                }
            case 3://body
                {
                    score--;
                    Debug.Log("body");
                    break;
                }
            default:
                {
                    break;
                }

        }
        scoreText.text = "SCORE: " + score;
    }
    /*private void Move()
    {
        enemy1.transform.position = new Vector3(enemy1.transform.position.x + Random.Range(-0.2f, 0.2f), enemy1.transform.position.y + Random.Range(-0.2f, 0.2f), enemy1.transform.position.z);
        enemy2.transform.position = new Vector3(enemy2.transform.position.x + Random.Range(-0.2f, 0.2f), enemy2.transform.position.y + Random.Range(-0.2f, 0.2f), enemy2.transform.position.z);
        enemy3.transform.position = new Vector3(enemy3.transform.position.x + Random.Range(-0.2f, 0.2f), enemy3.transform.position.y + Random.Range(-0.2f, 0.2f), enemy3.transform.position.z);
    }*/
    public void Awake()
    {
        inst = this;
    }
    void timer()
    {
        /*int change = Random.Range(0, 3);
        switch (change)
        {
            case 3:
                enemy1.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137); //¬õ
                Property.set_property_ball3(0);
                enemy2.GetComponent<MeshRenderer>().material.color = new Color(249, 255, 0); //¶À
                Property.set_property_ball4(2);
                enemy3.GetComponent<MeshRenderer>().material.color = new Color(0, 169, 255); //ÂÅ
                Property.set_property_ball5(1);
                break;
            case 2:
                enemy1.GetComponent<MeshRenderer>().material.color = new Color(249, 255, 0); //¶À
                Property.set_property_ball3(2);
                enemy2.GetComponent<MeshRenderer>().material.color = new Color(0, 169, 255); //ÂÅ
                Property.set_property_ball4(1);
                enemy3.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137); //¬õ
                Property.set_property_ball5(0);
                break;
            case 1:
                enemy1.GetComponent<MeshRenderer>().material.color = new Color(0, 169, 255); //ÂÅ
                Property.set_property_ball3(1);
                enemy2.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137); //¬õ
                Property.set_property_ball4(0);
                enemy3.GetComponent<MeshRenderer>().material.color = new Color(249, 255, 0); //¶À
                Property.set_property_ball5(2);
                break;
        }*/
        Property.set_property_ball3(0);
        Property.set_property_ball4(1);
        Property.set_property_ball5(2);
    }
}
