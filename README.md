# Jetski

Jetski is a custom Unreal Engine C++ movement controller inspired by the skiing and jet mechanics of *Tribes: Ascend*, extended to work with dynamic ocean waves.

## Features

- **Skiing Physics**  
  Low-friction movement down slopes with velocity projection onto the ground plane. Gravity is applied along the slope to naturally accelerate players downhill.

- **Air Control**  
  Quake/Source-style air acceleration for smooth, skill-based momentum steering when airborne.

- **Boost / Jet Impulse**  
  Directional impulse aligned with the player’s view, usable in air, on slopes, or while gliding on waves.

- **Water Glide**  
  Movement projected onto a moving wave surface. Uses relative velocity against the surface, planing lift, and splash drag to simulate surfing down swells as if they were ramps.

- **Subsurface Arc**  
  A special underwater state triggered on smooth entry. Preserves momentum into a low-drag ballistic parabola, allowing players to dip beneath obstacles and resurface without losing speed.

---

Jetski is designed as a foundation for high-speed, momentum-based gameplay on both land and water. It aims to provide a familiar *ski + jet* feel while introducing new mechanics for large-scale wave traversal and underwater momentum arcs.
