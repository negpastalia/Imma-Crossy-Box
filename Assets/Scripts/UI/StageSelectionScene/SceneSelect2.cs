using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelect2 : MonoBehaviour
{
	public Button selection;
	void Start () {
		Button btn = selection.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("Stage 2 Loaded");
		//SceneManager.LoadScene("SceneName");
	}
}