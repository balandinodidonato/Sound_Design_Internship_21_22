# Gamekit 3D Sound Design Internship 21/22 ReadMe

This Project is a fork of the Unity Technologies GameKit3D repository. It is being utilised to for the Sound Design Internship 21/22.

## Project Overview
The aim of this project is to produce the audio for the Unity 3D game kit level. The audio is to be fully procedural i.e. produced from scratch. This is facilitated by the Pure Data visual scripting language. Patches produced in Pure Data will be implemented into Unity using middleware such as WWise and converting created PD patches into Wwise plugins using the Heavy Compiler by Enzien Audio.

The created audio aims to be a realistic and more controllable option for the game audio. Demonstrating a gained understanding of procedural audio from research and experimentation while also gaining experience in a professional team setting and using professional version control methods.

### Mentor/Project Sponsor
 - Balandino Di Donato 

### Interns 
 - David Graham
 - Modestas Skadeilis 

## Using Provided Plugins (or Adding Your Own)
These examples are for a 64-bit Windows device, to do this for mac please refer to the HVCC documentation as this requires a couple extra steps. https://github.com/enzienaudio/hvcc/blob/master/docs/06.wwise.md

### Wwise Authoring Plugins
Wwise SDK Installation Folder (EG C:/programfiles(x86))/Audiokinetic/wwise 2019.2.1.7250/Authoring/x64/Release/bin/plugins

### Wwise Source Plugins (In Unity)
Project Folder (In this case the repository folder EG C:/github)/Sound_Design_Internship_21_22/Assets/Wwise/Deployment/Plugins/Windows/x86_64/DSP/

# Set-Up Instructions
In order to use this repository you must first install all the correct software. 
### 1. Git & Git LFS
https://git-scm.com <p>
Download the Git from the link above. <p>
The Git installer includes Git LFS by default as a tickbox that is pre-checked but ensure this is the case as git LFS is neccessary to correctly download the repository. 

### 2. GitHub Desktop
https://desktop.github.com <p>
Download the GitHub Desktop from the link above. <p>
The Program will allow you to clone the repository. Click the green Code button on GitHub in the browser and copy the link to the respoitory and put it into the Clone repository via URL tab in GitHub Desktop. Depending on where you save the respotitory it may generate a trust this repository pop-up once it finishes downloading. If you do not accept it will remmove the repository from your system.
 
### 3. Unity Editor version 2020.3.18f1
https://unity.com <p>
Download the Unity Hub from the link above. <p>
This will require you to sign in also, then install the unity editor version 2020.3.18f1. Any future release of the unity editor should also work, however, this has not been tested by the maintainers of the repository. Once this has been installed add the repository folder to the unity hub, using the add project button.
 
### 4. Wwise version 2019.2.1.7250 (Only neccessary if you plan to add to or change the respository) 
https://www.audiokinetic.com/en/ <p>
Download the Wwise Launcher from the link above. <p>
This will ask you to sign in then you will need to install Wwise Version 2019.2.1.7250 (change latest to all, 2019.2, 2019.2.1.7250). Install the SDK and at least the windows files. You can then access the project (unity level and wwise project) from the unity tab in the launcher.
 
### 5. Pure Data version 0.52-1 (Only neccessary if you plan to add to or change the respository)
http://puredata.info <p>
Download Pure Data from the link above. <p>
This program requires no further configurtion to work as intended although on MacOS the programm will need to request access to your microphone.  

### 6. Python 2.7 (Only neccessary if you plan to add to or change the respository)
https://www.python.org/downloads/ <p>
Download Python 2.7 from the link above. <p>
This needs to be python version 2 not python 3. Due to when HVCC was created. <p>
Make sure that python adds its self to PATH (in Windows this should be an auto checked box but is neccessary for the HVCC to function).
 
### 7. Visual Studio
https://visualstudio.microsoft.com/vs/ <p> (Only neccessary if you plan to add to or change the respository)
Download Visual Studio from the link above. <p>
This is needed to compiler your wwise plugins and also to edit any scripts in unity.
This requires a addon to the C++ components the C++ MFC component
 
### 8. HVCC by Enzien Audio (Only neccessary if you plan to add to or change the respository)
https://github.com/enzienaudio/hvcc <p>
Clone the HVCC Repository from the link above. <p>
Refer to the official documentation for the repository when using this tool for the best result and more options.
 (Quick Process Sum Up)
 - The basic process for this tool is:<p>
 - Open HVCC folder in Terminal/Command Line <p>
 - Type python hvcc.py *Insert your Pure Data Patch File Path Here* -n *Insert Your Desired Name Here* -g *Insert Chosen Playform Here*
 - Hit Enter, The Program will produce the files in the same folder as the patch.
 - Then use Visual Studio to compile the plugin, these will require retargeted to a more modern windows build before swapping to the release version and building the solution.
 
 Audiokinetic have a video on this process https://youtu.be/ftucjYF5QX8
  
### Extra Info
This Project is a fork of the unity-Technologies repository for their 3D Game Kit. Also Avaliable through the Unity Asset Store.
https://github.com/Unity-Technologies/Gamekit3D <p>
https://assetstore.unity.com/packages/templates/tutorials/3d-game-kit-115747
