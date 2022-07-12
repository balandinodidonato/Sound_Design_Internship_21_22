# Gamekit 3D

This Project is a fork of the Unity Technologies GameKit3D repository. It is being utilised to for the Sound Design Internship 21/22.

## Project Overview
The aim of this project is to produce the audio for the Unity 3D game kit level. The audio is to be fully procedural i.e. produced from scratch. This is facilitated by the Pure Data visual scripting language. Patches produced in Pure Data will be implemented into Unity using middleware such as WWise and converting created PD patches into Wwise plugins using the Heavy Compiler by Enzien Audio.

The created audio aims to be a realistic and more controllable option for the game audio. Demonstrating a gained understanding of procedural audio from research and experimentation while also gaining experience in a professional team setting and using professional version control methods.

### Mentor/Project Sponsor
 - Balandino Di Donato 

### Interns 
 - David Graham
 - Modestas Skadeilis 

## Running the Repository 
Reasons for each of these can be found within the Requirements page of the Wiki. <p>
Wwise version 2019.2.1.7250
https://www.audiokinetic.com/en/

Unity Editor version 2020.3.18f1
https://unity.com

Pure Data version 0.52-1
http://puredata.info

HVCC by Enzien Audio
https://github.com/enzienaudio/hvcc

Unity 3D Game Kit
https://github.com/Unity-Technologies/Gamekit3D

GitHub Desktop
https://desktop.github.com

Git & Git LFS
https://git-scm.com

## Using Provided Plugins (or Adding Your Own)
These examples are for a 64-bit Windows device, to do this for mac please refer to the HVCC documentation as this requires a couple extra steps. https://github.com/enzienaudio/hvcc/blob/master/docs/06.wwise.md

### Wwise Authoring Plugins
Wwise SDK Installation Folder (EG C:/programfiles(x86))/Audiokinetic/wwise 2019.2.1.7250/Authoring/x64/Release/bin/plugins

### Wwise Source Plugins (In Unity)
Project Folder (In this case the repository folder EG C:/github)/Sound_Design_Internship_21_22/Assets/Wwise/Deployment/Plugins/Windows/x86_64/DSP/
