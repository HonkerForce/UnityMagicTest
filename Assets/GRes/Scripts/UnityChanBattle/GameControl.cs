using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
	// public static bool gameIsStart = true;

	public static bool gameIsPause = true;

	public static Action<Vector3> targetChange = null;

	public static Action<string> gameOver = null;

	public static UnityAction initPlayer = null;

	public static UnityAction initMonster = null;

	public static UnityAction startGame = null;

	private Button startBtn;
	private TextMeshProUGUI startBtnTxt;
	private TextMeshProUGUI showTxt;

	private GameObject uiCanvasObj;

	void Awake()
	{
		gameOver = GameOver;
	}

    void Start()
    {
	    uiCanvasObj = GameObject.Find("UICanvas");

		startBtn = GameObject.Find("StartBtn").GetComponent<Button>();
	    // if (gameIsStart)
	    {
		    startBtn?.onClick?.AddListener(initMonster);
			startBtn?.onClick?.AddListener(initPlayer);
			startBtn?.onClick?.AddListener(startGame);
	    }

	    startBtnTxt = startBtn?.GetComponentInChildren<TextMeshProUGUI>();
	    showTxt = GameObject.Find("ShowTxt").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }

    void GameOver(string strRet)
    {
	    if (!gameIsPause)
	    {
			gameIsPause = true;
			Debug.Log("Game Over~£¡");
			uiCanvasObj?.SetActive(true);
			if (startBtnTxt != null)
			{
				startBtnTxt.text = "Restart";
			}

			string strShow = "";
			switch (strRet)
			{
				case "win":
				{
					strShow = "Win!";

					break;
				}

				case "fail":
				{
					strShow = "Fail!";

					break;
				}
			}

			if (!string.IsNullOrEmpty(strShow) && showTxt != null)
			{
				showTxt.text = strShow;
			}
	    }
	}
}
