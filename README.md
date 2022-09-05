# Nreal_ToFAR

Simple sample of "ToF AR" hand tracking on Nreal AR glasses

![nr_tofar_02](https://user-images.githubusercontent.com/530182/188435312-8c9c4906-43a2-46d4-9a6c-3a0a98baf3a0.png)
![nr_tofar_01](https://user-images.githubusercontent.com/530182/188435381-bc06e971-565b-44b7-9cc5-edd065d400bb.jpeg)

"ToF AR" is a xR SDK for integrated LiDAR/ToF camera phones released by Sony, that includes high accuracy hand tracking.  
https://developer.sony.com/develop/tof-ar/

This sample enables ToF AR hand tracking on nreal AR glasses.

Video: https://twitter.com/peugeot106s16/status/1565695130413461507

## Environment

* Unity 2020.3.x
* ToF AR v1.0.0
* NRSDK v1.9.5

## How to Build

1. Download "ToF AR" from Sony Developer World.
2. Open project with Unity Editor.
3. Import following 2 "ToF AR" unitypackage files.  
* TofAR_Base_v1.0.0_Android.unitypackage
* TofAR_Hand_v1.0.0_Android.unitypackage
4. Import NRSDK Unity package.
5. **[IMPORTANT]** Disable Assets/TofAr/TofAr/Plugins/Android/arm64-v8a/libc++_shared.so for avoid Gradle build error.
![FbXa23gaMAA_8AB](https://user-images.githubusercontent.com/530182/188437190-68422145-4168-4395-84a9-2ab99077c068.png)

6. Build and deploy to device.



## Lisence

This project is licensed under the MIT License, see the LICENSE.txt file for details
