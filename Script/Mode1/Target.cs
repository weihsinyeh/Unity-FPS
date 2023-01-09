using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public void Die()
    {
        Destroy(gameObject);
    }
}
