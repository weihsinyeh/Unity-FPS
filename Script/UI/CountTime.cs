using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CountTime : MonoBehaviour
{
    static int second;
    Text count;
    void Start()
    {
        second = 60;
        count = GetComponent<Text>();
        InvokeRepeating("timer", 1, 1);
    }

    void Update()
    {
        count.text = "Time : " + second.ToString("0") + " s";
    }
    public void timer()
    {
        second --;
        if (second == 0)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(7);
        }
    }
}
