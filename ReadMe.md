This program takes a little bit of trial and error to get to work.
The reason is I could not find a way to get a reference to the webelement for the Download button,
so I have to resort to clicking the screen at a certain location.

The problem is the location of the download button moves down based on the length of the prompt.

To fix this, if you are running via code in Visual Studio, change your prompt and locations in the
Init method.

If you are running via an install app (coming soon), then you have to start the app and change
the prompt and values. If the button is too high on the screen, increase the value for
DownloadsButtonPoint2 control value (the right one). With trial and error you should be able to 
figure it out for each prompt.

I may try and come up with a number of characters in the prompt and see if I can adjust the
values. Might not, it is pretty easy to fix manually.

Instructions

1. Start the app
2. Set your prompt and the number of images you want to create
3. Before you try and run 25 (= 100 images), make sure 1 works.
Pay attention when the Download button is clicked after a large version of an image is shown.
This is the part you will most likely have to fidget with to get right.
4. Make sure your Users Downloads Folder is correct, and choose a folder to serve as your Output
Folder.

# Important

In the version of Chrome that launches, click Settings on the right hand side menu, and change the 
zoom to 150% (or adjust all the values to what works for you).

Log In Microsoft with your personal MS account. You might have to join Bing if you haven't yet.

It will ask you to remember your password, but it won't remember it because each time the Chrome
expiremental version launches it is a new instance.

If you are running Visual Studio, you can rebuild with the values you wish set in the Init method
and next time you run the app it will restore those values. I will come up with a way for installed
version later.

Note: The box for remove Bing copyright is checked by default. When this is checked, the copyright
is removed by taking the top 968 pixels, resizing the image to 1,024 pixels. This was easier than 
anything else I could think of.

C# Programmer Only - The resizing is done using my Nuget package DataJuggler.PixelDatabase.
Take a look at the code. Only a few lines of code is required.

# Don't Forget

Keep track of your number of boosts on Bing. If you run out of boosts, this app will stop working
if Bing starts running slowly.

Let me know your thoughts. Is this cool or what?




