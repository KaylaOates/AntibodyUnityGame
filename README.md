![alt text](UnityGame/Assets/Images/gameplay_background.png)
# Antibody Game

Game created during the Dream Team Engineering 2024 Design-a-thon! We were given 24 hours to complete a game that helps children understand medical related concepts.

## Background Story
Inside the kingdom of your body, your immune system is the army that protects it from invaders. Antibodies are like the scouts of the army. They are always on the lookout for invaders, such as bacteria and viruses. When an invader enters the body, the antibodies latch on to it and identify it. They then send a signal to the rest of the immune system to attack the invader. The immune system then sends out white blood cells to destroy the invader. Once the invader has been destroyed, the antibodies remember it. This means that if the same invader enters the body again, the antibodies will be able to recognize it and quickly send out white blood cells to destroy it. This is why people who have had diseases like chickenpox and measles usually don't get them again.

## Scenes
- Start Scene: Hit play to begin! Transitions to the story scene
- Story Scene: Background story to our game, as scrolling text with a continue button at the end. Hit the button to move to the next scene: instructions
- Instruction Scene: How to play: Use the arrow keys to move the main character around. Stop the viruses from passing!
- Game Play: User controlles the Antibody through the bloodstream. As viruses appear, the antibody should be moved to stop it. Once stopped, a pop-up appears describing the virus which is then attacked by white a group of while blood cells and eventually destroyed.

## Scripts
- AntibodyController: allows the user to move the antibody with the arrow keys and stay within the bounds of the screen.
- CollisionScript: Attached to each virus, when they collide with the antibody it triggers a pop-up and white blood cell attack.
- CounterScript: Displays the game score, controlled by the number of collisions with viruses.
- InfoPopUpClicked: Pops-up when a virus collides with the antibody. Different info box for each virus. Disappears when clicked
- MoveLeft: The movement script for the viruses.
- MovePrefab: Movement script for text boxes in the instructions scene.
- StoryScroll: Scrolling movement for the story screen.
- Spawener: Creates new viruses to pop-up on the screen.

## Software Info
Unity Version: 2020.3.26f1

## Developers
- Kayla
- Tiffany
- Grant
- Natalie
