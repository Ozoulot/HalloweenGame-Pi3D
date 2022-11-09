# HalloweenCandyHunt Miniproject

## Overview of the Game
The project was inspired by the game Phasmophobia’s Halloween event, but without the threat of a ghost. 
The player controls the first-person camera with WASD to look for candy. The goal of the game is to collect the candy around the map and light lanterns to score points, and then ending the game by interacting with a car.

The main parts of the game are:
-	Player – First-person camera, moved with W A S D keys.
-	Camera – Following the player object, rotates field of view with the mouse, crouching lowers the camera.
-	Candy – Different candy laid around the play area. The candy has a faint glow to them to make it easier to find and can be picked up by pressing E on the keyboard.     Each candy gives 1 “point” on the clipboard.
-	Clipboard – The player has a clipboard where they can see the progress of collecting candy and lighting lanterns in the form an of UI.
-	Lighter – A lighter that the player can pick up turn on and off by pressing F, drop, and use to turn on lanterns.
-	Lanterns – Pumpkins that can light up when the player touches them with a lighter.
-	Play field – Area with different themes, a graveyard with a church, a house, a forest, and a road. Everything is closed off by invisible walls or fences. The player   can freely move around the obstacles in the playfield.
-	Car – The player can go to the red car on the road to end the game.

Game features:
-	Candy is hidden around the map, making the player look for it in different places.
-	Lanterns are placed around the map; the player can light them up with the lighter.
-	The game keeps track of a score in the form of candy picked up or lanterns lit and shows it on a UI.
-	The game uses free models from the unity asset store, to make it more visually interesting, and more fitting of the Halloween theme.
-	The whole game consists of one scene.

## Project Parts:

### Scripts:
- playerMovement – is attached to the player object and makes it able to be controlled with WASD keys. Also makes the camera follow the player, while being able to look around with input from the mouse moving.
-	pickUp1 – is attached to the gameobjects Flashlight and Lighter. Controls if the player can pick up the items by pressing E and if the player can drop the items by pressing Q. 
- Flashlight – is attached to two spotlights in the scene. Controls if the player can turn the spotlight on or off by pressing F.
-	Lighter – is attached to the Lighter gameobject. Checks if the lighter is colliding with other gameobject with the tag “Lighter” if it does it calls a function from another script.
-	ClipPick – Is attached to the clipboard gameobject, controls if the clipboard can be picked up, and if it is then it is controlling the toggling of a GUI, which displays the score of the game.
-	CandyPick – Is attached to all candy gameobjects. Controls if the player can pick up the candy, calls a function from another script and disables the gameobject in the scene.
-	Score – Is attached to the canvas attached to the Clipboard. Gives the player a point each time the candy is picked up and displays it on the clipboard.
-	TurnonLant – Is attached to the pumpkins placed around the map. Disables the pumpkin gameobject and enables the PumpkinGlow gameobject when the lighter collides with the pumpkins.
-	ScoreLant – Is attached to the canvas attached to the Clipboard. Gives the player a point each time a lantern is turned on and displays it on the clipboard.
-	Car – Is attached to the Vehicle gameobject. Controls if the player can interact with the car or not, then opens the GameOverUI.
-	GameOverUI – Is attached to the FPSCam gameobject. Controls whether the player quits the game or continues, based on what button they press on the GUI.

### Models & Prefabs with materials/textures:
Free models downloaded from the Unity Asset store:
- Candy: https://assetstore.unity.com/packages/3d/props/food/allsorts-candy-12512
- Car: https://assetstore.unity.com/packages/3d/vehicles/land/realistic-mobile-car-demo-173467
- Church: https://assetstore.unity.com/packages/3d/environments/fantasy/church-3d-68143
- Clipboard: https://assetstore.unity.com/packages/3d/props/clipboard-137662
- Fences: https://assetstore.unity.com/packages/3d/environments/medieval-fence-pack-11618
- Graveyard: https://assetstore.unity.com/packages/3d/environments/old-game-stylized-props-pack-110066
- Halloween: https://assetstore.unity.com/packages/3d/props/halloween-pumpkin-lantern-153723
- Horse Statue: https://assetstore.unity.com/packages/3d/environments/fantasy/horse-statue-52025
- Lighter: https://assetstore.unity.com/packages/3d/props/cigarette-lighter-pbr-106937
- Metal Table: https://assetstore.unity.com/packages/3d/props/furniture/furniture-free-pack-192628
- Old Building: https://assetstore.unity.com/packages/3d/environments/industrial/old-building-70659
- Pumpkins: https://assetstore.unity.com/packages/3d/props/halloween-free-pumpkin-101968
- Trees: https://assetstore.unity.com/packages/3d/environments/environmental-asset-pack-170036

### Materials:
Free materials/textures downloaded from Unity asset store:
- Nature:	https://assetstore.unity.com/packages/2d/textures-materials/nature/nature-materials-vol-2-32020
- Asphalt:	https://assetstore.unity.com/packages/2d/textures-materials/roads/asphalt-materials-141036

### Sounds: 
All used sounds are downloaded from: https://pixabay.com/sound-effects/

### Testing:
- The game was tested on Windows 11, have not been tested on Linux or Mac. Does not work on mobile and no plans for it to do so.

##Time Management
| **Task**                                                                       | **Time it Took (in hours)**        |
|--------------------------------------------------------------------------------|------------------------------------|
|     Setting up Unity, making a project in GitHub	                             |     0.5                            |
|     Research and getting idea for game                                         |     1                              |
|     Finding 3D models                                                          |     1.5                            |
|     Other research in terms of how to do different scripts etc.                |     4                              |
|     Building the game scene                                                    |     2                              |
|     Making a working lighter (flashlight)                                      |     1                              |
|     Getting the lanterns to light up individually when plyer touches them      |     1.5                            |
|     Placing candy and lanters around the game scene                            |     1                              |
|     Candies can be picked up                                                   |     1                              |
|     Making UI for the clipboard using Canvas and Textmesh Pro                  |     0.5                            |
|     Pick up paper for clipboard, be able to show and hide UI with keypress     |     1.5                            |
|     Candies and lanterns give points when interacted with                      |     2                              |
|     Collisions and bugfixing in terms of lantern and lighter                   |     1.5                            |
|     Making UI for ending the game with Canvas, Buttons and Textmesh Pro        |     0.5                            |
|     Interactable car to end the game using UI buttons                          |     1.5                            |
|     Testing that everything works as intended                                  |     2                              |
|     Code documentation + cleanup                                               |     3                              |
|     Making readme/report                                                       |     2.5                            |
|     **Total time used**                                                        |     **30**                         |

## Used Resources

### Videos watched:
-	First person camera and player movement -  https://www.youtube.com/watch?v=f473C43s8nE&ab_channel=Dave%2FGameDevelopment
-	Toggling a flashlight on/off - https://www.youtube.com/watch?v=QNBt25aBz7Y&t=84s&ab_channel=BigBirdGames
-	Pick up and drop items - https://www.youtube.com/watch?v=8kKLUsn7tcg&t=214s&ab_channel=Dave%2FGameDevelopment
-	Score counter - https://www.youtube.com/watch?v=YUcvy9PHeXs&ab_channel=CocoCode
-	Exit game using buttons - https://www.youtube.com/watch?v=ZVfAbGa3obk&ab_channel=GameDevTraumUploads

### Forums/Websites read:
-	Flashlight starts turned off - https://answers.unity.com/questions/632456/flash-light-off-on-start.html
-	Changing the rotation of a picked up item - https://stackoverflow.com/questions/64887572/unity-object-orientation-in-player-hand-changes-depending-on-angle-of-object-pic
