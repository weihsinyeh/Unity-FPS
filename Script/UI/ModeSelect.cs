using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class ModeSelect : MonoBehaviour, IPointerClickHandler
{
    static public int mode_get;
    public int mode;
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(2);
        mode_get = mode;
    }
}
