# 🕹️ Console Pong Game

A classic Pong game recreated as a console application using C# and .NET 6. This project was developed as part of the **Programming Fundamentals** course at **SoftUni Buditel**.

This is a minimalistic two-player console game that demonstrates object-oriented programming, user input handling, real-time rendering, and basic game mechanics — all within a terminal interface.

---

## 🚀 Features

- 🎮 Two-player paddle control (Player 1 & Player 2)
- ⏱️ Real-time ball movement with trajectory physics
- 🧱 Bordered game field using a 2D character array
- 🧠 Collision detection with walls and paddles
- 🧮 Score tracking and display
- ♻️ Automatic reset of the ball and paddles after scoring
- 🔊 Optional sound feedback using `Console.Beep()`
- 📏 Adjustable ball speed using frame skipping
- 🧼 Console cleanup and redraw for smoother visuals

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 6 (LTS)
- **IDE:** Visual Studio 2022+
- **Version Control:** Git & GitHub
- **App Type:** Console Application

---

## 🎮 Controls

**Player 1 (Left Paddle):**
- `W` – Move Up
- `S` – Move Down

**Player 2 (Right Paddle):**
- `↑ (Up Arrow)` – Move Up
- `↓ (Down Arrow)` – Move Down

---

## 🧩 Game Architecture

### Field
- 2D `char[,]` array with customizable width and height
- Automatically draws top/bottom borders

### Racket
- Each player has an independent `Racket` instance
- Includes movement, drawing, and reset methods

### Ball
- Tracks direction using booleans
- Handles collision with field borders and rackets
- Supports random trajectory on reset (can be extended)




