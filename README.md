Flappy Bird Clone

A simple, fun recreation of the classic Flappy Bird game in Unity. 
This project demonstrates basic game mechanics such as jumping physics, gravity, 
obstacle generation, and collision detection.

PlayerMovement (Bird)
-Jump Mechanic: Press a key (e.g., Spacebar) to make the bird flap upward. 
-The playermodel cycles betweem 3 sprites emulating motion with the wings.
-The bird is constantly pulled down by gravity, requiring well-timed jumps to stay in the air.

Collision Detection
-If the bird touches a pipe, the game ends.
-The game also ends if the bird hits the ground or goes out of bounds.

Obstacles
-Random Pipe Generation: Pipes spawn continuously at random heights.
-Scrolling Effect: Pipes move from right to left across the screen.

Scoring
-Gain points by successfully passing through pipe gaps, the points reset to 0 when dying. 

Game states 
-When the game is launched it will be paused until you press the play button. 
-When you die the game pauses until you press the plau button again. 

Parallax Background

-To make the game feel more dynamic and visually appealing, the project includes a parallax scrolling background. 
-This technique creates an illusion of depth by moving background layers at different speeds.
-The far background (sky, clouds, distant hills, etc.) scrolls slowly, simulating depth.
-The ground scrolls the faster, adding to the effect.
-As each layer scrolls off-screen, it is looped seamlessly to create continuous motion.
-Even though the bird stays in almost the same place horizontally, 
-the parallax system creates the feeling that the bird is flying through a scrolling world. 



https://github.com/user-attachments/assets/cec4b22b-aa89-41f2-be2e-1f0428b91f3f



How to Play
-Press SPACE/Leftclick to flap.
-Avoid hitting pipes.
-Survive as long as possible to increase your score. 

Sources 
-https://www.youtube.com/watch?v=ihvBiJ1oC9U
