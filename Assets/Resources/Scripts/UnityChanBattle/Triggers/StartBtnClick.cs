using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtnClick : MonoBehaviour
{
	void Awake()
	{
		if (GameControl.startGame == null)
		{
			GameControl.startGame = StartGame;
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
	 //    if (GameControl.gameIsStart)
	 //    {
		// 	GameControl.gameIsStart = false;
		// }

	    GameObject.Find("UICanvas")?.SetActive(false);
        GameControl.gameIsPause = false;
    }
}
