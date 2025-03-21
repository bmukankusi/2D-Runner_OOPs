# 2D-Runner_OOPs
# Player State & Movement System in Unity

This Unity project demonstrates the **Singleton, State, and Strategy Design Patterns** while implementing a **2D Player Controller**. The player can move, jump, collect power-ups, avoid obstacles, and reach a goal flag.

## Features

- **Movement Controls**: 
  - Use **Arrow Keys (`←` `→`) or A/D keys** to move.
  - Press **Spacebar** to jump (Double jump enabled).
- **Speed Boost**: 
  - Collect the **Speed Increaser(Yellow-Orange Sprite)** to move twice as fast.
- **Health System**:
  - **Collide with a Spike** → Lose **5 HP**.
  - **If HP is below 30**, the text turns **red**.
  - **If HP reaches 0**, the game is **over**.
- **Game Win Condition**:
  - Reach the **Flag** → See **"Yay! You won!"** + a **celebration effect**.
- **Dynamic UI Updates**:
  - The player's **current state** is displayed (e.g., Moving, Jumping, Speed Boosted).
- **Camera Follow**:
  - The **camera follows the player smoothly** in all directions.

## Design Patterns Used

Design Pattern | Purpose
- **Singleton**: Manages the **GameManager** to control game state and UI.
- **State**: Handles **player states** dynamically (`GroundedState`, `JumpingState`, `SpeedingState`). 
- **Strategy**: Implements **movement behaviors** (`NormalMovement`, `SpeedBoostMovement`).

## Others
- Unity version: 2022.3.55f1
- Graphics: Unity Assets & Images




 
