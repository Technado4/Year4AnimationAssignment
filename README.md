This is a report for the work done within my animation project, showing each step I took in order to create, rig and import and 3D animated character into the Unity Engine

Character Creation:  
The program "Makehuman" was used to create the character seen in this assignment. My reference used for this model was the character "Mario" from the "Super Mario" games although the resemblance is hard to spot due to Makehuman's lack of creative tools. Clothes, specifically some overalls and boots were included in the model

![](https://imgur.com/TV0mZWH)

Animation Events:

Two animation events were added, specifically when the jump animation reaches the peak of its height and when the run animation kicks its left leg forward. Both will evoke methods in a custom script that changes the content of a custom UI text on screen, specifically stating "Bro jumped" and "Bro walked".

Ragdoll:

A ragdoll effect was added by adding a ragdoll to the player's armature, adjusting the collider sizes and setting all of the rigidbodies to Kinematic. By disabling the animator and character controller and setting every rigidbody to non-kinematic it causes the character to enter a ragdoll state
