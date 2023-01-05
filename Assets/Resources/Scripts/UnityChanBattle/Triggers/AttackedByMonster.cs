using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AttackedByMonster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
	    if (GameControl.gameIsPause)
	    {
		    return;
	    }
	    if (other != null && other.tag == "Monster")
	    {
		    // µ÷ÓÃÎ¯ÍÐ
		    string strParam = "";
		    if (PlayerControl.isAttacking)
		    {
			    strParam = "win";
		    }
		    else
		    {
			    strParam = "fail";
		    }
		    GameControl.gameOver?.Invoke(strParam);
	    }
    }
}
