# Performance Bounceback Starter Project

This project is part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.4.15
- SteamVR v2.0.1

## Updates
Replaced the older SteamVR plugin with the new version. 
- The SteamVR "[CameraRig]" has been replaced with the "[Player]" prefab. 
- Ball prefab has the scripts "Interactable", "Velocity Estimator", and "Throwable" to support SteamVR default grab controls. 
- Removed Throw script as it's no longer needed.

Oliver Cheok
Took me 2 hours
I like being able to see a huge performance increase after optimising the entire scene according to the rubrics.
The challenging part is able to identify and narrow down what was causing the bottleneck specifically for XR.WaitForGPU; I manage to get it down by adding more Probe Groups and adjusting the type of lights to baked.

Steam VR Version 1.27
Oculus Rift