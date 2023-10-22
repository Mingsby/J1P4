using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
	public GameObject[] Levels;

	private int _currentIndex = 0;

	private void Start()
	{
		foreach(GameObject g in Levels)
		{
			g.SetActive(false);
		}

		Levels[_currentIndex].SetActive(true);
	}

	public void ChangeLevel(int index)
	{
		Levels[_currentIndex].SetActive(false);
		_currentIndex = index;
		Levels[_currentIndex].SetActive(true);
	}

	public void CirculateLevel()
	{
		int newLevel = (_currentIndex + 1)%Levels.Length;
		ChangeLevel(newLevel);
	}
}