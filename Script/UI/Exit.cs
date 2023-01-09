using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

using UnityEngine;

public class Exit : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData e)
    {
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
}
