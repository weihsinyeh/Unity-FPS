using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Wall_Right").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        GameObject.Find("Wall_Left").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        GameObject.Find("Wall_Top").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        GameObject.Find("Wall_Buttom").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        GameObject.Find("Wall_Front").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
        GameObject.Find("Wall_Back").GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
    }
}
