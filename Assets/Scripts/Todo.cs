using UnityEngine;
using System.Collections;

public class Todo : MonoBehaviour {
	/*
	 * Game Overview:
	 * - 25 levels, first 5 free
	 * - Each level has the basic goal of collecting "stars" and finding the exit, however there will also be three 
	 *   "challenges" for each level, for example "don't touch blue walls" or "don't collect any stars"
	 * - Levels can be modified by the camera/ball behavior
	 * 		- "Arkanoid-"style level, where goal is behind breakable blocks; tilting the level is limited to 30 degrees
	 * 		  and tilting also moves the paddle at the bottom of the screen; ball isn't affected by gravity
	 * 		- "Pinball-"style level, where paddles automatically activate when touched by the ball. Try to get X points
	 * 		  to activate the goal. Tilting limited to 30 degrees
	 * 		- "Fixed Camera" level. Tap & rotate changes gravity, but not the angle of the camera
	 * 		- "No gravity" level. Must rotate the level to get the ball through and not rely on gravity.
	 * 		- "High gravity" level. Need quicker reaction time to get past spikes, etc.
	 * 		- "Regular" level. Just to get acclimated	
	 * 
	 * 
	 * TODO:
	 * 1. Figure out if possible to write JSON to disk
	 * 2. Test out UIToolKit, determine if it's possible to "parent" UI objects
	 * 3. Determine if it's possible to adjust UIToolKit images based on screen size
	 * 		- each object should have a "setSize" method. You could have a "screen" singleton which stores 
	 * 		  DPI, resolution, and a "scale" factor
	 * 4. Learn about texture types
	 * 
	 * Destroyed gameObjects won't play their sounds
	 * Create bouncing bumper
	 * Create collectable star
	 * Fix camera angle to point directly towards ball
	 * Write boilerplate for Game Manager singleton
	 */
}
