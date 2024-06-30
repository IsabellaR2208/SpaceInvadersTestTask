using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	private Text startLabel;

	void Start()
	{
		startLabel = GetComponent<Text>();

#if UNITY_EDITOR || UNITY_STANDALONE
		startLabel.text = "Tap to Continue";
#elif UNITY_IOS || UNITY_ANDROID
		startLabel.text = "Press Start to Continue";
#endif
	}

	void Update () {
#if	UNITY_EDITOR || UNITY_STANDALONE
		if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown (KeyCode.Space) ||	Input.GetMouseButton(0) )
				SceneManager.LoadScene ("main");
#elif UNITY_IOS || UNITY_ANDROID	
		if (Input.touchCount > 0)
			SceneManager.LoadScene ("main");
	
#endif
	}
}
