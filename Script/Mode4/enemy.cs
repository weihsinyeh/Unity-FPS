using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class enemy : MonoBehaviour
{
    [SerializeField] float turnSpeed = 90f;
    public Text operation;
    static public bool shoot = true;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = -1;
        GameObject.Find("eye1").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        GameObject.Find("eye2").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        GameObject.Find("Head").GetComponent<MeshRenderer>().material.color = new Color(100, 100,0);
        GameObject.Find("hand1").GetComponent<MeshRenderer>().material.color = new Color(100, 100,0);
        GameObject.Find("hand2").GetComponent<MeshRenderer>().material.color = new Color(100, 100,0);
        GameObject.Find("Body").GetComponent<MeshRenderer>().material.color = new Color(100, 100, 0);
        GameObject.Find("mouth").GetComponent<MeshRenderer>().material.color = new Color(255, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        if(transform.localRotation.eulerAngles.y > 180 && transform.localRotation.eulerAngles.y <360)
        {
            operation.text = "可以射擊";
            GameObject.Find("eye1").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
            GameObject.Find("eye2").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
            shoot = true;
        }
        else
        {
            operation.text = "躲起來";
            GameObject.Find("eye1").GetComponent<MeshRenderer>().material.color = new Color(255, 0, 0);
            GameObject.Find("eye2").GetComponent<MeshRenderer>().material.color = new Color(255, 0, 0);
            shoot = false;
        }
    }
}
