﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete : MonoBehaviour {

	public void LoadNextLEvel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
}
