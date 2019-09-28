using System;
using SplashKitSDK;

public class Program{
    public static void Main(){
        //Window object and background bitmap creation
        Window fightWindow = new Window("Ryu Animation3", 640, 480);
        Bitmap background = new Bitmap("Fight Arena", "BG.png");
        fightWindow.DrawBitmap(background,0,0);

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

        shoryuken.Play();
        SplashKit.Delay(300);
        
        //Action Sequence 
        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu1, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200); 

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu2, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu3, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu4, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu4, 150, 75);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu4, 150, 50);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu5, 150, 75);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu5, 150, 100);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu6, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu7, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(200);

        fightWindow.DrawBitmap(background,0,0);
        fightWindow.DrawBitmap(Ryu1, 150, 150);
        fightWindow.Refresh();
        SplashKit.Delay(10000);
    }
}
