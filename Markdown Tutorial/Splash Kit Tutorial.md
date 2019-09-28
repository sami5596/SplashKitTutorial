# Tutorial - How to Setup SplashKit and Make a Simple Animation
**By:** Mohammad Samiullah Belal

In this tutorial, we will be looking at how to setup SplashKit SDK and use C# to make a simple animation.  

This tutorial is divided into the following sections:
1. Install MSYS2 Terminal on your PC
2. Install SplashKit SDK
3. Install Visual Studio Code
4. Install C# language tool extension in VS Code
5. Install Dotnet core tools for C#
6. Create and Setup Project directory
7. Write a small code to test everything
8. Build and run the program
9. Download Resources
10. Write the code
11. Finalize

At the end of this tutorial, we will be able to draw a scene using tool in SplashKit SDK.

### 1. Install MSYS2 Terminal on your PC.
MSYS is a terminal to windows platform. This terminal is required for running commands that will help us in building programs.
Let's get started.
1. Download and install [MSYS2](http://www.msys2.org/). Make sure you install the correct version i.e. "i686" for 32-bit Windows and "x86_64" for 64-bit Windows.
![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/MSYS2HomePage.png "MSYS2 Home Page")
2. Run the installer and follow instructions to install MSYS2 terminal. Run terminal at the end.
![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/MSYSInstaller.png "MSYS2 Installer")
3. Next step is to update the package database with the following command. Run MSYS2 and enter the following command.
    ```
    pacman -Syu
    ```
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/Command.png "Terminal")
4. Run the following, if MSYS was closed, to update rest of the packages.
    ```
    pacman -Su
    ```
5. Now MSYS2 has been setup. We can move on to the next step.
### 2. Install SplashKit SDK.
Now that we have installed MSYS2 terminal, we can use this terminal run commands in order to install SplasgKit SDK.
Follow the steps to setup the SDK.
1. First of all, we need to install git client. This is necessary to download and install SplashKit. Use the following command to install git client.
    ```
    pacman -S git --noconfirm --disable-download-timeout
    ```
2. After installing git client. Navigate to [SplashKit](https://www.splashkit.io/) homepage. There is a command line on the homepage. Copy it and run it in the terminal.
    ```
    bash <(curl -s https://raw.githubusercontent.com/splashkit/skm/master/install-scripts/skm-install.sh)
    ```
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/SplashKitHomePage.png "SplashKit Homepage")
3. Now close the terminal and open it again. Run the following command. You should see the following message.
    ```
    skm
    ```
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/Success.png "Success")
4. If you see the message in the above screenshot, **Congratulations**, you have successfully installed SplashKit SDK. Now we can move on to the next step.
### 3. Install Visual Studio Code.
Now that we have installed SplashKit SDK, it is time to install Visual Studio Code to do some coding.
**(if you have already installed VS Code in your computer, you can skip this step)**

Follow the steps below to install VS Code.
1. Go to [Visual Studio Code](https://code.visualstudio.com/) website and download the installer.
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/VisualStudioCode.png "VS Code Homepage")
2. Run the installer and follow on-screen instructions.
3. That is it, now you can move on to the step.
### 4. Install C# language tool extension in VS Code.
Now that we have installed MSYS2 terminal, SplashKit SDK and VS Code, there are only two more steps to follow before we can actually start working on our project.
Follow the steps below to install C# extension for VS Code.
1. Open up VS Code and click on the extensions button on the left hand side.
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/VSCode.png "VS Code Welcome Page")
    The window that opens up is basically a marketplace for extensions. There are many extensions available that can be installed and used with VS Code.
2. Search for C# in search bar and install the one by Microsoft. (I have already installed it. Hence, the screenshot shows uninstall button)
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/Marketplace.png "VS Code Marketplace")
    After installing the extension, it will automatically be enabled to use with VS Code.
3. After successful installation, we can move on to the next step.
### 5. Install Dotnet core tools for C#.
This is the final step in setting up everything before coding begis (yay!). 
Follow the steps to finish setting up eveything. 
1. Open the MSYS2 terminal and run the following command.
    ```
    pacman -S mingw-w64-{x86_64,i686}-gcc mingw-w64-{i686,x86_64}-gdb
    ```
2. Visit [Dotnet core](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install) website and download the installer suitable for your version of windows.
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/dotnet.png "Dotnet Homepage")
3. Run the installer and follow on-screen instruction to complete installation.
4. **Congratulations**, you have setup everything. Now in the following steps, we can start working on our project.
### 6. Create and Setup Project directory.
Now that we have setup everything, its time to start working on the project. 
1. Open up the terminal and use the following to change current location.
    ```
    cd path/to/directory
    ```
    Keep in mind when entering desired path, you must use '/' to separate folders. If there is a space in the name of folder then replace the space with '\ '. Note that the backslash is followed by a single space. That's how MSYS2 terminal understands that there is a space.
2. Now that we are in desired directory, we can either setup project in this directory or we can create a new folder in this location that will contain all the files related to project. It is a good practice to create separate folder for each project. Use the following command to create folder.
    ```
    mkdir Our\ Project
    ```
    (Notice how I have used '\ ' to indicate a space in name of folder).
    Now use the following command to make sure that we are inside this folder.
    ```
    cd Our\ Project
    ```
3. Now that we are in our folder, we can use the following commands to setup the project.
    ```
    skm dotnet new console
    ```
    After executing this command, execute the following command
    ```
    skm dotnet restore
    ```
    These commands will initialize the project. The first command is used to create a new project and second is used when you already have a project and need to restore its settings.
4. That's it. Our project has been succesfully setup. Let's move on to the next step.
### 7. Write a small code to test everything.
It's time to write a small code and to check if everything is working or not.
1. Open up VS Code.
2. Go to File > Open Folder > Select folder where you have initialized the project.
3. Now the project is open in Explorer. You can see all files and folders present in our project directory. Open the Program.cs file.
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/program.png "Program")
4. This is the main file in our code. Now let's write line of code that will print out to the console window. Paste the following code in Main() function.
    ```Csharp
    Console.WriteLine("Hello World!");
    ```
5. Now that you have written your first line of code, move on to next section to build and run the program.
### 8. Build and run the program.
Follow the steps to run the program and see the output.
1. Open up MSYS2 again and change to project directory (if not already in it).
2. Enter the following command to build the program.
    ```
    skm dotnet build
    ```
3. Now run the following command to run the program.
    ```
    skm dotnet run
    ```
    You should see the following output
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/Output.png "Output")
4. That's it. You have successfully created your own program.

In the next steps, we will create a simple animation using the SplashKit library and will create something great. 
### 9. Download Resources
Now let's get started on making an animation.
1. First thing first. Open up VS Code and open your project directory. 
2. In the explorer menu, you can see the project directory and its content. Go ahead and create a Resources folder. Create two more subfolders in Resources named Images and Sounds.
    ![alt text](https://raw.githubusercontent.com/sami5596/SplashKitTutorial/master/Markdown%20Tutorial/Images/Directory.png "Directory")
    These folders will hold the resources that we will use to make our animation.
3. Now to make a simple animation, we need sprites, images and sounds. Go to my GitHub Repository for this tutorial by [Clicking Here](https://github.com/sami5596/SplashKitTutorial). If you into the Project directory and then into resources, you will find all the resources that we will need for the animation to work. Go ahead and download these files. Makes sure to read the readme file as I do not have rights to these files. It is always the best thing to acknowledge the source.
4. Now that you have downloaded files. Keep them in the folders that we have created before. In the next step we will work on the code.
### 10. Write the code
Now. Let's write a code play animation
1. Clear out the main function.
2. Use the following code to initialize animation window and give it a background. (Note: This program will have redundant code. We can make it better using loops and functions but for the sake of this tutorial, I will be keeping the program straight forward for better understanding).
    ```Csharp
    //Window object and background bitmap creation
    Window fightWindow = new Window("Ryu Animation3", 640, 480);
    Bitmap background = new Bitmap("Fight Arena", "BG.png");
    ```
    The first line of the code generates a window object on which our animation will played. We have given a name to our window and the other two parameters defines the size of the window i.e. width and height respectively.
    The second line creates a new bitmap object and stores it in a bitmap type variable. The Bitmap function takes two arguments. First is the name for bitmap and second is the location of image.
3. Now, let's store our other resources in variables for later use. Use the following code.
    ```Csharp
    //Animation Bitmap object creation
    Bitmap Ryu1 = new Bitmap("Ryu1", "R1.png");
    Bitmap Ryu2 = new Bitmap("Ryu2", "R2.png");
    Bitmap Ryu3 = new Bitmap("Ryu3", "R3.png");
    Bitmap Ryu4 = new Bitmap("Ryu4", "R4.png");
    Bitmap Ryu5 = new Bitmap("Ryu5", "R5.png");
    Bitmap Ryu6 = new Bitmap("Ryu6", "R6.png");
    Bitmap Ryu7 = new Bitmap("Ryu7", "R7.png");

    //Soundeffect object creation
    SoundEffect shoryuken = new SoundEffect("Shoryuken", "shoryuken.mp3");
    ```
    The first seven variables are using the resources stored in our directory and storing them in variables. The SoundEffect object stores the sound file which will be played with our animation.
4. Now let's play our sound for the animation with the following code.
    ```Csharp
    shoryuken.Play();
    SplashKit.Delay(300);
    ```
    The first line is responsible for playing the sound until it ends. The second adds a delay before the next line in our program is executed. The delay that has been added is 300 milliseconds. This delay is added only to synchronize sound with our animation.
5. Now that the sound is playing, we need to add action as well. Use the following code and run the program and see what happens.
    ```Csharp
    fightWindow.DrawBitmap(background,0,0);
    fightWindow.DrawBitmap(Ryu1, 150, 150);
    fightWindow.Refresh();
    SplashKit.Delay(200); 
    ```
    Let's discuss each line one by one.
    The first line draws the background image on the window. The draw bitmap function takes bitmap variable as argument to be drawn. The other two variables are X and Y coordinates of where the bitmap will be drawn.
    The second line is responsible for drawing one image of our character on the screen at X: 150 and Y: 150. 
    The third line refreshes the window on our screens to actually display what has been drawn in the background. Keep in mind this line is important to actually see the difference.
    The fourth line adds a delay of 200 milliseconds beforen next line is executed. Again, this line has been added to synchronzie our animation with sound. This is also important, otherwise all of the bitmaps will be drawn and shown under a second. More precisely, the program is able to refresh screen 60 times a second (Refresh rate of most monitors).
6.  Now, if you run the program, you will see our character is standing still and not doing anything while the sound is playing. Now I want you to use the code snippet in the previous step and make use other bitmap variables to actually create the animation.
    Hint: You will have to use one bitmap more than once and change coordinates of bitmap drawing location to actually make the animation look good.
    (Note: The full code is available in the GitHub Repository [Here](https://github.com/sami5596/SplashKitTutorial). But it will be a good practice to mess around with the code and see what happens)
### 11. Finalize
Congratulations! you are now a master of setting up SplashKit SDK and VS Code and you also know how to use different SplashKit functionalities. You should see the [documentation](https://www.splashkit.io/api/animations/) to further learn about what more can you do with SplashKit SDK.
I hope this tutorial has been more than helpful to everyone who is reading this.
Thank You! :)