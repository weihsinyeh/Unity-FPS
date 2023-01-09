using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class ClassSelect : MonoBehaviour, IPointerClickHandler
{
    public static ClassSelect inst;
    public static int class_choice;
    public int class_outside;
    public void Awake()
    {
        inst = this;
    }
    // Update is called once per frame
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        switch(ModeSelect.mode_get)
        {
            case 1:
                {
                    SceneManager.LoadScene(1);
                    break;
                }
            case 2:
                {
                    SceneManager.LoadScene(3);
                    break;
                }
            case 3:
                {
                    SceneManager.LoadScene(1);
                    break;
                }
            case 4:
                {
                    SceneManager.LoadScene(1);
                    break;
                }
            case 5:
                {
                    SceneManager.LoadScene(1);
                    break;
                }
            case 6:
                {
                    SceneManager.LoadScene(3);
                    break;
                }
        }
        class_choice = class_outside;
        Debug.Log("Ãø«×" + class_choice);
    }
}
