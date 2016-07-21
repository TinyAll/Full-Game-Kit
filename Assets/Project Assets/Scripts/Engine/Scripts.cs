// ENGINE SCRIPT: AVOID PUTTING GAME SPECIFIC CODE IN HERE
// Stijn 23/07/2012
// This entire class only consist of static variables for easy access without having to create or get instances

/*
 * 描述：
 *  更容易的去获取句柄
 * 
 * 目标：
 *  创建 AudioManager
 *  创建 InputManager
 *  创建 CheatManager
 */
using UnityEngine;
using System.Collections;

public class Scripts
{
	// Managers
	public static InputManager inputManager = null;
	public static AudioManager audioManager = null;
	public static CheatManager cheatManager = null;
	public static MedalsBaseManager medalsManager = null;

	// Scripts (monobehaviors)
	public static LevelScript levelScript = null;
	public static InterfaceScript interfaceScript = null;

	// Advertising
	public static AdvertisingSample advertising;

	// Hammer 2 Specifics
	public static Hammer hammer;
	public static Map map;

	public static void Initialize()
	{
		Debug.Log("[Scripts] Initialize()");
		audioManager = new AudioManager(); // AudioManager creates object with 
		inputManager = new InputManager(); // Simple InputManager which handles generic input, like (un)pause, mute, etc.
		cheatManager = new CheatManager(); // Cheat script
	}
}
