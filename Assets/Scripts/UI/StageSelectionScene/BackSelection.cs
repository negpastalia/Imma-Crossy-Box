using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackSelection : MonoBehaviour
{
	public Button selection;
	void Start () {
		Button btn = selection.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("Back Pressed");
		//SceneManager.LoadScene("SceneName");
	}
}