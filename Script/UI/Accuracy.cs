using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accuracy : MonoBehaviour
{
    static public float accuracy;
    Text accuracyText;

    void Start()
    {
        accuracy = 0f;
        accuracyText = GetComponent<Text>();
    }

    void Update()
    {
        accuracyText.text = "Accuracy : " + accuracy.ToString("0") + " %";
    }
}
