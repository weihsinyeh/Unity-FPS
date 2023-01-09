using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcMove : MonoBehaviour
{
    /*
    public GameObject curGo;
    public GameObject targetGo;
    public float value;
    // Update is called once per frame
    void Update()
    {
        Vector3 center = (curGo.transform.position + targetGo.transform.position) / 2;
        center -= new Vector3(0, value, 0);
        Vector3 start = curGo.transform.position - center;
        Vector3 end = targetGo.transform.position - center;
        curGo.transform.position = Vector3.Slerp(start, end, Time.time / 200);
        curGo.transform.position += center;
        float dis = Vector3.Distance(curGo.transform.position, targetGo.transform.position);
        if(dis <= 1)
        {
            Debug.Log("到達目標點");
        }
    }*/
    public GameObject curGo;
    public GameObject targetGo;
    public float speed = 2;
    public int rotationAngle = 60;
    private float distanceToTarget;
    private bool move = true;
    private void Start()
    {
        distanceToTarget = Vector3.Distance(curGo.transform.position, targetGo.transform.position);
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    {
        while (move)
        {
            Vector3 targetPos = targetGo.transform.position;
            targetPos.z = 0;
            curGo.transform.LookAt(targetPos);
            float angle = Mathf.Min(1, Vector3.Distance(curGo.transform.position, targetPos) / distanceToTarget * rotationAngle);
            //curGo.transform.rotation = curGo.transform.rotation * Quaternion.Euler(Mathf.Clamp(-angle, -42, 42), 0, 0);
            float currentDist = Vector3.Distance(curGo.transform.position, targetGo.transform.position);
            if(currentDist < 0.5f)
            {
                move = false;
                Debug.Log("到達");
            }
            curGo.transform.Translate(Vector3.forward * Mathf.Min(speed * Time.deltaTime, currentDist));
            yield return null;
        }
    }
}
