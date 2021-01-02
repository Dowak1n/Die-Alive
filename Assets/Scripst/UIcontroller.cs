using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcontroller : MonoBehaviour
{
	public Text scoreDisplay;

	// Use this for initialization
	private void Start () 
	{
		GameManager.Instance.scoreEvent += ScoreChange;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	private void ScoreChange (int scores) 
	{
		if (scoreDisplay != null)
			scoreDisplay.text = scores.ToString();
	}


	private void OnDestroy()
    {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
}
