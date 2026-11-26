This is a report for the work done within my animation project, showing each step I took in order to create, rig and import and 3D animated character into the Unity Engine

<h2><u>Character Creation: </u></h2>
The program "Makehuman" was used to create the character seen in this assignment. My reference used for this model was the character "Mario" from the "Super Mario" games although the resemblance is hard to spot due to Makehuman's lack of creative tools. Clothes, specifically some overalls and boots were included in the model

<img src="https://i.imgur.com/TV0mZWH.png">

<h2><u>Character Rigging:</u></h2>
This model was then exported and sent to Blender where a rig was set up using the program’s bone tool, below is the fully rigged model in a T-Pose 

<img src="https://i.imgur.com/1Y9q63l.png">

<h2><u>Animation Clip Creation:</u></h2>
Two amateurish animation clips were made, one specifically of the character running and one of them jumping, both used Blender’s keyframe tools to animate as well as different easing types as an attempt at smoother movement. 

https://i.imgur.com/GnOQ6rB.gif<br>
https://i.imgur.com/qpq3aXr.gif

<h2><u>Unity Import:</u></h2> 
The model was imported into Unity’s Third person controller sample scene, and a custom humanoid avatar was made for the model. Adjustments had to be made to the avatar to prevent the arms and feet from being backwards in game 

https://i.imgur.com/5kCEXhV.gif

<h2><u>Animation State Machines and Blend Trees:</u></h2> 
The two animation clips were imported into the scene in separate FBX files, and new copies of the main model’s avatar were used on them. The animation state machine had a new blend tree added using a custom trigger parameter to switch between animations 

<img src="https://i.imgur.com/HuGvI7x.png">
<img src="https://i.imgur.com/icoA6IU.png">

<h2><u>Animation Events:</u></h2>

Two animation events were added, specifically when the jump animation reaches the peak of its height and when the run animation kicks its left leg forward. Both will evoke methods in a custom script that changes the content of a custom UI text on screen, specifically stating "Bro jumped" and "Bro walked".

https://i.imgur.com/I4MnJhA.gif

<h2><u>Ragdoll:</u></h2>

A ragdoll effect was added by adding a ragdoll to the player's armature, adjusting the collider sizes and setting all of the rigidbodies to Kinematic. By disabling the animator and character controller and setting every rigidbody to non-kinematic it causes the character to enter a ragdoll state

https://i.imgur.com/i5JMtFJ.gif

