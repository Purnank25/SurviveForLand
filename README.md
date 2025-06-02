# 🌀 Floating Ball Game

A simple Unity 3D game where the player controls a ball on a floating surface. Dodge enemy balls and use a power-up to launch yourself with high impulse!

## 🎮 Game Description

- The player is a **ball** that moves on a floating platform.
- Multiple **enemy balls** are spawned and attempt to collide with the player.
- A single **power-up** is also spawned which, when collected, gives the player a **burst of high impulse** (boost).

## 🛠️ Features

- Smooth Rigidbody-based ball movement.
- Enemies chase the player using directional force.
- Power-up gives the player a temporary high-force boost.
- Game built using Unity and C#.

## 📸 Output

https://github.com/user-attachments/assets/6cbc1513-e0af-4a2d-9325-9c4293e4730a

## 🚀 How to Play

1. Use the arrow keys or `WASD` to move the player ball.
2. Avoid getting hit by enemy balls.
3. Collect the power-up to gain a burst of potential energy and escape danger.

## 🧠 Game Mechanics

- **Player Movement:** Uses `Rigidbody` forces for realistic physics.
- **Enemy Behavior:** Enemies use `AddForce()` to move toward the player.
- **Power-Up:** On trigger, adds a strong impulse to the player’s Rigidbody.

## 🧰 Tech Stack

- Unity 2021+ (or later)
- C# (MonoBehaviour scripts)
- Rigidbody physics system



