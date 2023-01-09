using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gun_mode2: MonoBehaviour
{
    private GameObject raycastedObj;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private Image uiCrosshair;
    public GameObject ballPrefab_3,ballPrefab_4,ballPrefab_5,friend;
    private int index = 0,property,times=0;
    private GameObject clone1, clone2, clone3, clone4,clone5,clone6,clone7,clone8;
    GameObject temp;
    int shootCount;
    int hitCount;
    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
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
                temp = GameObject.Find(hit.collider.gameObject.name);
                temp.SetActive(false);
                if(temp.gameObject.name == "ballPrefab_3")
                {
                    property = Property.get_property_ball3();
                }
                if(temp.gameObject.name == "ballPrefab_4")
                {
                    property = Property.get_property_ball4();
                }
                if (temp.gameObject.name == "ballPrefab_5")
                {
                    property = Property.get_property_ball5();
                }
                Manager.inst.Score(property);
                SpawnBall(temp);
                if (ClassSelect.class_choice == 2 || ClassSelect.class_choice == 3)
                {
                    if (property == 2 || property == 1)//殺到Friend多出很多敵人混淆視聽
                    {
                        Spawn_friend(hit.collider.gameObject.transform.position);
                    }
                }
                hitCount++;
                shootCount++;
            }
            else
            {
                shootCount++;
            }
            Accuracy.accuracy = (float)hitCount / shootCount * 100;
        }
        if (ClassSelect.class_choice == 2 || ClassSelect.class_choice == 3)
        {
            if (times == 20)
            {
                times = 0;
                CancelInvoke("Move");
                GameObject[] temp = GameObject.FindGameObjectsWithTag("enemy");
                for (int i = 0; i < temp.Length; i++)
                {
                    Destroy(temp[i]);
                }
            }
        }
    }
    public void SpawnBall(GameObject temp)
    {
        temp.transform.position = GetRandomPoint();
        temp.SetActive(true);
        index++;
    }
    public void Spawn_friend(Vector3 origin)
    {
        clone1 = Instantiate(friend);
        clone1.transform.position = origin;
        clone2 = Instantiate(friend);
        clone2.transform.position = origin;
        clone3 = Instantiate(friend);
        clone3.transform.position = origin;
        clone4 = Instantiate(friend);
        clone4.transform.position = origin;
        clone5 = Instantiate(friend);
        clone5.transform.position = origin;
        clone6 = Instantiate(friend);
        clone6.transform.position = origin;
        clone7 = Instantiate(friend);
        clone7.transform.position = origin;
        clone8 = Instantiate(friend);
        clone8.transform.position = origin;
        InvokeRepeating("Move", 0, 0.05f);
    }
    public void Move()
    {
        float angle45 = 0.707106781f;
        times++;
        clone1.transform.position = new Vector3(clone1.transform.position.x + 1, clone1.transform.position.y, clone1.transform.position.z);
        clone2.transform.position = new Vector3(clone2.transform.position.x, clone2.transform.position.y + 1, clone2.transform.position.z);
        clone3.transform.position = new Vector3(clone3.transform.position.x - 1, clone3.transform.position.y, clone3.transform.position.z);
        clone4.transform.position = new Vector3(clone4.transform.position.x, clone4.transform.position.y - 1, clone4.transform.position.z);
        clone5.transform.position = new Vector3(clone5.transform.position.x + angle45, clone5.transform.position.y + angle45, clone5.transform.position.z);
        clone6.transform.position = new Vector3(clone6.transform.position.x + angle45, clone6.transform.position.y - angle45, clone6.transform.position.z);
        clone7.transform.position = new Vector3(clone7.transform.position.x - angle45, clone7.transform.position.y - angle45, clone7.transform.position.z);
        clone8.transform.position = new Vector3(clone8.transform.position.x - angle45, clone8.transform.position.y + angle45, clone8.transform.position.z);
        clone1.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
        clone2.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
        clone3.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
        clone4.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
        clone5.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
        clone6.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
        clone7.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
        clone8.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 137);
    }
    Vector3 GetRandomPoint()
    {
        Vector3 point = new Vector3(Random.Range(-10, 10),Random.Range(-10, 10),11);
        return point;
    }
}
