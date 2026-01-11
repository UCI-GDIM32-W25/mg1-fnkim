[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
1. Frances Kim (she/her) (I also go by Fanny but I'm cool with either)


2. The plan in my MG1 breakdown activity used attributes like the sprite of the player and number of seeds available, and actions like the movement and spawning functionality. In the code, this was implemented through the Player script, which is a MonoBehavior class. There is a method in this script called PlantSeed() which spawns in a seed by instantiating the seed prefab at the position of the player. This instantiated seed becomes a GameObject. The Update() method is used to detect key presses and move the player based on them as well as call PlantSeed() when space is pressed. The number of seeds remaining and the number of seeds planted is changed each time PlantSeed() is called.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
