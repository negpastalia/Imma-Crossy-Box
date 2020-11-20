using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelect3 : MonoBehaviour
{
	public Button selection;
	void Start () {
		Button btn = selection.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("Stage 3 Loaded");
		//SceneManager.LoadScene("SceneName");
	}
}