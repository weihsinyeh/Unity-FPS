//葉惟欣12/31 場景轉換，
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

using UnityEngine;

public class SceneSwitcher : MonoBehaviour, IPointerClickHandler
{
    public int SceneIndexDestination = 0;
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData e)
    {
        // get the current scene
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneIndexDestination);
    }
    void Update() //回主畫面
    {
        if ((Input.GetKey(KeyCode.R))&& (Input.GetKey(KeyCode.Space)))
        {
            Scene scene = SceneManager.GetActiveScene();

            SceneManager.LoadScene(0);
        }
    }
}
