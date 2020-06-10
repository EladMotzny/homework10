# Wall Jumper

Move with WASD, look around with your mouse and jump with space.

Can you collect all of the coins?

## Functionality
The player can move, jump and jump off walls to a different wall or to a higher place and hit the goal to see if he won.
For the player movement I used [this code in the Updated function](https://github.com/EladMotzny/homework10/blob/254de1bdb6206539a7b12c07bf63479d51a14029/homework10/Assets/Scripts/PlayerMovement.cs#L38-L61) that checks if the player is on the ground or jumping and calculates his gravity and velocity accordingly. If the player jumps while colliding with a wall, [The player can jump again](https://github.com/EladMotzny/homework10/blob/254de1bdb6206539a7b12c07bf63479d51a14029/homework10/Assets/Scripts/PlayerMovement.cs#L65-L76)
![image](https://user-images.githubusercontent.com/33173449/84268803-ef500480-ab30-11ea-8971-ce47a04fe75b.png)

## UI
We made a simple UI using TextMeshPro which updates [every time a coin is collected.](https://github.com/EladMotzny/homework10/blob/254de1bdb6206539a7b12c07bf63479d51a14029/homework10/Assets/Scripts/PlayerMovement.cs#L79-L97) The function also counts the number of coins the player has and according to that the game gives a different game over screen.
![image](https://user-images.githubusercontent.com/33173449/84268714-c62f7400-ab30-11ea-9fc9-a7c9a2a2d893.png)
