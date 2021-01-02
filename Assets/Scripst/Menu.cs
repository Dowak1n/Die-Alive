using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour

{
	public void StartGame()
	{
		SceneManager.LoadScene (2);
	}

	public void easy()
	{
		SceneManager.LoadScene (1);
	}

	public void fine()
	{
		SceneManager.LoadScene (3);
	}

	public void hard()
	{
		SceneManager.LoadScene (4);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	public void Back()
	{
		SceneManager.LoadScene (0);
	}

	public void Settings()
	{
		SceneManager.LoadScene (5);
	}


}
