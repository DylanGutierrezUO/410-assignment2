# No team for this assignment. All features made by Dylan Gutierrez
# Remark: This project runs in the version it was donwloaded as, 6000.0.43f1

## 🧪 Added Gameplay Features

As part of the assignment, the following gameplay enhancements were added to the "John Lemon" project:

---

### 🧮 1. Dot Product – Enemy Vision Detection
- Implemented custom enemy field-of-view detection using the **dot product**.
- Enemies compare their forward direction to the direction of the player.
- If the player is within range and angle, they are considered "seen".

---

### 🧊 2. Linear Interpolation – Haunted Chair Movement
- A haunted chair floats eerily between two points using **`Vector3.Lerp`**.
- Rotation speed also uses **linear interpolation** to vary over time, making the chair spin unpredictably.
- Enhances the atmosphere and unpredictability of the environment.

---

### 🎇 3. Particle Effect – Enemy Alert Indicator
- A **3D question mark** particle (from an imported asset) appears above the enemy when they detect the player.
- It is instantiated at runtime and always faces the camera.
- Serves as a visual indicator of enemy awareness.

---

### 🔊 4. Sound Effect – Alert SFX
- A custom **"huh.wav"** sound effect plays when the enemy first detects the player.
- It only plays once per detection, using `AudioSource` playback logic.

---

### 🪑 5. Haunted Chair Interaction – Player Shove
- When the haunted chair touches the player, it **physically shoves them** using `AddForce`.
- This can push the player into enemies or hazards, adding tension.
- Two chairs exist in the level: one at the beginning, and one near the end.

---

### 🧪 Testing & Validation
- All features were tested in Play Mode.
- Both haunted chairs push the player correctly.
- Sound and particle effects only trigger when the player is seen by an enemy.
