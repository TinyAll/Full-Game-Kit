// ENGINE SCRIPT: AVOID PUTTING GAME SPECIFIC CODE IN HERE

using UnityEngine;
using System.Collections;
/*
 * 描述：
 *  输入管理
 *  
 * 目标：
 *  控制levelScript中的游戏暂停
 * 
 * 
 */
public class InputManager
{
	// Constructor
	public InputManager(){
	}

	public void Update(){

		if (Data.pausingAllowed)
		{
			bool tPauseKey = Input.GetKeyUp(KeyCode.P) || Input.GetKeyUp(KeyCode.Escape) || Input.GetButtonUp("Joystick Pause");
			if (tPauseKey)
			{
				if (Data.pause)
				{
					Scripts.levelScript.UnPauseGame();
				} else
				{
					Scripts.levelScript.PauseGame();
				}
			}
		}
	}
}
