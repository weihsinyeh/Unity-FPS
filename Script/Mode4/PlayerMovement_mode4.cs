using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class PlayerMovement_mode4 : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float groundDistance = 0.4f;
    private bool can_decrease = false;
    private bool start = true;
    Vector3 velocity;
    int time_int = 5;
    private void Start()
    {
        InvokeRepeating("timer", 1, 1);
    }
    void timer()
    {
        time_int -= 1;
        if (time_int == 0)
        {
            start = false;
            CancelInvoke("timer");
        }
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.up *z;
        controller.Move(move* speed * Time.deltaTime);
        
        if (enemy.shoot == false && transform.position.y > -5)
        {
            if (transform.position.y > -12)
            {
                if (can_decrease == true)
                {
                    GameObject.FindObjectOfType<Score>().AddScore(-20);
                    can_decrease = false;
                }
            }
        }
        if(enemy.shoot == true && start== true)
        {
            can_decrease = true;
        }
    }
}
