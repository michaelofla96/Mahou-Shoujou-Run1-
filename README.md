# Mahou-Shoujou-Run1-
Assignment 3
Sean Meyler
C15431532
 DT228 -2 Object Oriented Programming

# Youtube Video

[![Video](http://img.youtube.com/vi/-jXwU1Bzw4o/0.jpg)](http://www.youtube.com/watch?v=-jXwU1Bzw4o&feature=youtu.beE)

For my third assignment I decided to make another game titled Mahou Shoujo Run! The game is an endless runner type game where the Mahou Shoujo must run through a dangerous cave collecting gems and avoid spikes and stalactites. The art was created by myself in Photoshop as were the 2 main soundtracks which were created in MuseScore. I just an anime style for the characters and a cartoonish look for the obstacles.
The game is made with Unity and coded in C#.

# Features

- Different Main Menu options, New Game, Settings, Help, Exit.
- Game Over Screen
- Unique Art Style
- Original Soundtrack
- Spawn Systems, timed and random
- Player Controls, Jumping and Shooting
- Animations, Running and Jumping

# Controls

- Mouse Click - Fires a Spell projectile in direction of falling Stalactites
- SpaceBar - Make Mahou Shoujo jump
- Point and Click - To navigate between different Menu screens

# Functionality

Main Menu

- Selection of option that when highlighted change colour and when clicked Load a different Scene. (New Game, Settings, Help, Exit)

New Game

- Loads the scene GameStart.

Settings

- Can Mute sounds and return to Main Menu. Highlighted buttons are also used here.

Help

- Shows a list of controls and what they're used for and a button to return to Main Menu.

Exit

- Exits the game.

GameStart

- A score system which is increased every second making the play want to last longer. Also increases by collecting gems.

- Starts the game. There is a few scripts running here for spawning of different objects. The gem spawn script creates a different gem clones at different intervals and when the gem collides with the Mahou Shoujo they destroy themselves and the Score is increased.

- Stalactites and Spikes and spawn using a scripts which spawns the objects a random times from a spawn point and gives them random speed.

- If the Stalactites or Spikes collide with the Mahou Shoujo, the scene Game_Over loads.

Game_Over

- This is a game over screen which gives the player the option to play again or return to the Main Menu.
