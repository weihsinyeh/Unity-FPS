//腑暴猋12/31
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gun : MonoBehaviour
{
    //public GameObject shootAudio = null;
    public GameObject BackGround;
    private GameObject raycastedObj;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private Image uiCrosshair;
    public GameObject ballPrefab_0,ballPrefab_1,ballPrefab_2;
    private string ballDeleteName;
    int shootCount;
    int hitCount;
    /*****GridShot*******************************************************************/
    float change = 0.9f;
    //mode =0 夹非家Α //  mode = 1硉家Α //  mode = 2弘非家Α
    /*****GridShot********************************************************************/
    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (ClassSelect.class_choice == 2) //硉家Α
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
            if (Physics.Raycast(ray, out hit) && !((hit.collider.gameObject.tag) == "BackGround"))
            {
                Vector3 position = GameObject.Find(hit.collider.gameObject.name).transform.localPosition;

                ballDeleteName = hit.collider.gameObject.name;
                Destroy(GameObject.Find(ballDeleteName));
                //if (shootAudio != null)
                //    Instantiate(shootAudio, Vector2.zero, Quaternion.identity); 甮阑贾
                GameManager.inst.IncrementScore();
                SpawnBall(position);
                Accuracy.accuracy = (float)hitCount / shootCount * 100;
                hitCount++;
                shootCount++;
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
    public void SpawnBall(Vector3 position)
    {
        switch(ballDeleteName)
        {
            case "ballPrefab_0":
            case "ballPrefab_0(Clone)":
                {
                    GameObject temp = Instantiate(ballPrefab_0);
                    temp.transform.position = GetRandomPoint(position);
                    if (ClassSelect.class_choice == 3) //precision mode
                    {
                        float size = Random.value + 0.5f;
                        temp.transform.localScale = new Vector3(size, size, size);
                    }
                    else //ぃ琌precision mode
                    {
                        temp.transform.localScale = new Vector3(1, 1, 1);
                    }
                    break;
                }
            case "ballPrefab_1":
            case "ballPrefab_1(Clone)":
            {
                    GameObject temp = Instantiate(ballPrefab_1);
                    temp.transform.position = GetRandomPoint(position);
                    if (ClassSelect.class_choice == 3) //precision mode
                    {
                        float size = Random.value + 0.5f;
                        temp.transform.localScale = new Vector3(size, size, size);
                    }
                    else //ぃ琌precision mode
                    {
                        temp.transform.localScale = new Vector3(1, 1, 1);
                    }
                    break;
                }
            case "ballPrefab_2":
            case "ballPrefab_2(Clone)":
            {
                    GameObject temp = Instantiate(ballPrefab_2);
                    temp.transform.position = GetRandomPoint(position);
                    if (ClassSelect.class_choice == 3) //precision mode
                    {
                        float size = Random.value + 0.5f;
                        temp.transform.localScale = new Vector3(size, size, size);
                    }
                    else //ぃ琌precision mode
                    {
                        temp.transform.localScale = new Vector3(1, 1, 1);
                    }
                    break;
                }
        }
    }
    //GrideShoot 
    Vector3 GetRandomPoint(Vector3 position)
    {
        //Vector3 point = new Vector3(Random.Range(-5, 5),Random.Range(-5, 5),20);
        Vector3 new_position;
        do
        {
            float change = Random.value;
            float distance = Random.Range(1, 4);
            if (Random.value < 0.5) //传よ
            {
                distance *= -1;
            }

            if (change < 0.5)
            {
                new_position = new Vector3(position.x + distance, position.y + distance, position.z);
            }
            else if (change < 0.75)
            {
                new_position = new Vector3(position.x + distance, position.y, position.z);
            }
            else
            {
                new_position = new Vector3(position.x, position.y + distance, position.z);
            }
        } while (new_position.x > 15 || new_position.x < -15 && new_position.y > 15 && new_position.y < -15);
        return new_position;
    }
}
