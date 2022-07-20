My two Enemey AI scripts. Version 2 got scrapped and is not used in the project at all and it is not in a working state because the complexity just ended up ballooning out of control.

The enemy AI has three main functionalities:

1. It will patroll in a designated radius.
2. It will start chasing the player if the player enters the sight radius.
3. It will damage(attack) the player if it is within the attack radius.
4. I also tried to make it so that the player does not get swarmed by all of the enemies within sight radius all at once by implementing a  enemies engaged variable that should prevent the AI from engaging if the player is already in combat with 3 enemies.
5. There are also a couople of timers to make sure that the player is not invincible when engaged by the max number of enemies.
6. Most of the values which are important for controlling the AI are stored in the AI_parameters scriptable object.