using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
	Button MenuButton;

	void Start()
	{
		MenuButton = GetComponent<Button>();
		MenuButton.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene(0);
	}
}
