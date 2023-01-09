//腑暴猋12/31
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gun_mode4 : MonoBehaviour //跟窟窟家Α
{
    //public GameObject shootAudio = null;
    private GameObject raycastedObj;
    
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private Image uiCrosshair;
    public GameObject ballPrefab_0,ballPrefab_1,ballPrefab_2;
    int shootCount;
    int hitCount;
    /*****GridShot*******************************************************************/
    float change = 0.9f;
    //mode =0 夹非家Α //  mode = 1硉家Α //  mode = 2弘非家Α
    /*****GridShot********************************************************************/
    private void Start()
    {
        GameObject.Find("ballPrefab_0").GetComponent<MeshRenderer>().material.color = new Color(0, 255, 255);
        GameObject.Find("ballPrefab_1").GetComponent<MeshRenderer>().material.color = new Color(0, 255, 255);
        GameObject.Find("ballPrefab_2").GetComponent<MeshRenderer>().material.color = new Color(0, 255, 255);
        Scene scene = SceneManager.GetActiveScene();
        if (ModeSelect.mode_get == 1) //硉家Α
        {
            InvokeRepeating("changesize", 1, 1);
        }
        shootCount = 0;
        hitCount = 0;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && !((hit.collider.gameObject.tag) == "BackGround") && !((hit.collider.gameObject.tag) == "enemy")&& !((hit.collider.gameObject.tag) == "hide"))
            {
                Vector3 position = GameObject.Find(hit.collider.gameObject.name).transform.localPosition;
                GameObject.FindObjectOfType<Score>().AddScore(1);
                SpawnBall(position, hit.collider.gameObject);
                hitCount++;
                shootCount++;
                //Debug.Log("sdfsfsfsdfwerwe"+Accuracy.accuracy);
            }
            else
            {
                shootCount++;
            }
            Accuracy.accuracy = (float)hitCount / shootCount * 100;
        }
    }
    void changesize()
    {
        Vector3 objectScale;
        if (ballPrefab_0 != null)
        {
            objectScale = ballPrefab_0.gameObject.transform.localScale;
            if (objectScale.x > 0.4f)
            {
                ballPrefab_0.gameObject.transform.localScale = new Vector3(objectScale.x * change, objectScale.y * change, objectScale.z * change);
            }
        }
        if (ballPrefab_1 != null)
        {
            objectScale = ballPrefab_1.gameObject.transform.localScale;
            if (objectScale.x > 0.4f)
            {
                ballPrefab_1.gameObject.transform.localScale = new Vector3(objectScale.x * change, objectScale.y * change, objectScale.z * change);
            }
        }
        if (ballPrefab_2 != null)
        {
            objectScale = ballPrefab_2.gameObject.transform.localScale;
            if (objectScale.x > 0.4f)
            {
                ballPrefab_2.gameObject.transform.localScale = new Vector3(objectScale.x * change, objectScale.y * change, objectScale.z * change);
            }
        }
    }
    public void SpawnBall(Vector3 position,GameObject temp)
    {
        temp.transform.position = GetRandomPoint(position);
    }
    Vector3 GetRandomPoint(Vector3 position)
    {
        Vector3 point;
        do
        {
            float change = Random.value;
            float distance = Random.Range(1, 4);
            if (Random.value < 0.5)
            {
                distance *= -1;
            }
            if (change < 0.5)
            {
                point = new Vector3(position.x + distance, position.y + distance, position.z);
            }
            else if (change < 0.75)
            {
                point = new Vector3(position.x + distance, position.y, position.z);
            }
            else
            {
                point = new Vector3(position.x, position.y + distance, position.z);
            }
        } while (point.x > 15 || point.x < -15 || point.y > 15 && point.y < -15);
        return point;
    }
}
