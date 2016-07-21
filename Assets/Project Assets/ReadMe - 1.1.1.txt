----------------------------------------------
Full Game Kit: Hammer 2           
Copyright 2015 Xform
Version 1.1.1
----------------------------------------------

Thanks for buying Full Game Kit: Hammer 2

Documentation can be found here:
http://xform.nl/projects/AssetStore/Hammer2/Hammer2Documentation.pdf
This file is also located in the Project Assets folder, right beside this ReadMe file!

Support can be gotten through here:
support@xformgames.com

License notes:
You may use all source codes and assets in your own projects and games, also if they are for commercial use.
But you may not distribute the source code or assets directly, for instance in the Asset Store ;).
If you've obtained this software from any other source than the Asset Store,
your license is effectively invalid, and Xform cannot provide support for it.

--------------------------
Installation
--------------------------
Download and import the package from the Unity Asset Store into a preferably new Unity Project.
Alternatively you can try copying the already unpacked contents into a Unity Project.
Download and import the package from the Unity Asset Store into a preferably new Unity Project.
Alternatively you can try copying the already unpacked contents into a Unity Project.
If you're having trouble using your Xbox 360 controller, be sure to check if the ProjectSettings/InputManager.asset is updated correctly.
If not, overwrite it with the InputManager.asset inside Hammer2InputManger.zip located in the Project Assets folder.

--------------------------
Play the game in the editor
--------------------------
Open the StartUp, Loading or Game scene in the Scenes folder.
Press Play.

--------------------------
Create a build
--------------------------
Choose File > Build Settings
Choose your platform.
Press Build.

Supported and tested platforms:
Web Player
Standalone (Win, Mac, Linux)
WebGL (Preview)

--------------------------
Controls
--------------------------
Keyboard
Control:			Action:
WASD/Arrows			Move
Mouse				Aim
Space/J				Jump or ascend or drift
LMB/Z				Fire
RMB/X				Grenade or descend
MouseWheel/Q/E		Change weapon
Shift/C				Activate HammerTime
Enter/E				Enter or exit vehicle
Esc/P				Pause
M					Mute audio toggle

Controller
Control:					Action:
Left Analog Stick			Move
Right Analog Stick			Aim
A							Jump or ascend or drift
Right Trigger/Shoulder/X	Fire
Left Trigger/Shoulder/B		Grenade or descend
D-Pad Left/Right			Change weapon
Left Stick Button			Activate HammerTime
Y							Enter or exit vehicle
Start						Pause

Touch
Control:				Action:
Drag left stick			Move
Drag right stick		Aim
Double tap right stick	Reset view
Tap up button			Jump
Tap blue button			Fire
Tap red button			Throw grenade
Hold timer button		Hammer Time!
Tap cycle button		Cycle weapon
Tap enter button		Enter vehicle
Tap pause button		Pause game

Cheats*
Key:				Cheat:
K					Mission Complete
L					Game Over
G					God mode toggle (no damage)
I					Toggle interface
O					Toggle player visibility
T					Almost get all achievements
U					Unlock missions
C					Give 100000 cash

*Not available on touch devices.

--------------------------
 Version History
--------------------------
1.1.1
- FIXED: Compatibility issue for XGradient.cs for Unity 5.2.2

1.1.0
- TIP: There is an issue in Unity 5.2 regarding alphabetical sorting. Turn this off in you hierarchy view!
- NEW: Android build support with mobile controls
- NEW: CursorManager (see CursorManager.cs)
- NEW: PoolManager (See PoolManager.cs, PoolData.cs and PoolVisualizer.cs)
- NEW: AutoAim (See Hammer.cs and CharacterManager.cs)
- NEW: Advertising (See AdvertisingSample.cs to see how you could show advertising)
- NEW: Mobile localization
- FIXED: Camera offsetting. The camera will now keep looking correctly when it has been offset because of objects behind it.
- FIXED: Set camera layerCullDistances properly on camera creation
- FIXED: Some camera settings for turrets and tanks
- FIXED: Bunch of small non-critical issues.
- FIXED: Compatibility issue for XGradient.cs for Unity 5.2
- ISSUES: See Unity forums/issue tracker on Alphabetically sorting and particle position issues. There is a workaround for the last one in this package.

1.0.4
- FIXED: Vehicle collision NullReferenceException in Vehicle.cs

1.0.3
- FIXED: Localization typo
- FIXED: Animation Events being triggered with no component to handle it.
- FIXED: No more warnings when picking up weapons and gadgets while in a vehicle.
- FIXED: Removed some inactive vehicles from Game scene

1.0.2
- NEW: Added controls and cheats to the ReadMe
- FIXED: HammerTime controller issue
- FIXED: Animator no receiver warning and errors
- FIXED: AttackHelicopter controls where you would shoot and fly up at the same time

1.0.1
- FIXED: Turret, MissileTurret, MammothTank and AttackHelicopter secondaryfire controls
- FIXED: F22 controller input
- FIXED: Xbox 360 controller input not used properly. 
- NEW: Added the InputManager.asset to the Project Assets folder for convenience.
- NEW: More comments in the UI related scripts.
- FIXED: Mammoth Tank explosion was missing a material reference.
- NEW: Added this document to the package.

1.0.0
- NEW: Initial build.
