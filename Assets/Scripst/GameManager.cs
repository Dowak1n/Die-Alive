using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager 
{
	public static GameManager Instance
    {
	    get
        {
			if (_instance == null)
				_instance = new GameManager ();
			return _instance;
		}
	}

	public delegate void EventScoreHandler(int scores);
	public event EventScoreHandler scoreEvent = delegate {};

    private int _userScores = 0;
	private static GameManager _instance;


	public void DeadUnit(GameObject unit)
	{
		switch (unit.tag)
        {
		    case "Player":
			    GameOver ();
			    break;
		    case "Enemy":
			    _userScores += 100;
			    scoreEvent(_userScores);
			    break;
		}

	}


	private void GameOver()
	{
		scoreEvent = delegate {};
		SceneManager.LoadScene(0);
	}
}
