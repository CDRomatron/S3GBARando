# S3GBARando
Attack of the rhynocs randomiser, written as a C# application.

Credits:
Muffinjet (for prior work on project)
RayCarrot (for reverse engineering map data as part of ray1map)

#Running the program
1: Extract the .zip
2: Place your US "Spyro: Attack of the Rhynocs" GBA file alongside the .exe
3: Rename the file to s3.gba
4: Run S3GBARandoApp.exe. It should run through, and create two files. settings.csv and mod.gba (the game is not changed yet). Press enter to close the window.

Inital setup is done.

#To do the Plandomiser

1: Open settings.csv (I recommend notepad or notepad++)
2: All the lines are laid out as "normal item id location","what item will go where id". Only edit the parts after the ,

For example, to swap the item the Toddler gives you at the start with the Ice Scroll the Fairy gives you at the start you would change the following:
0x4A,0x4D
0x4D,0x4A

For IDs, see https://docs.google.com/spreadsheets/d/1zRk6WPDMs599Jm5ozapCbqeKYa4BhecbcHsPZXeqE50/edit?usp=sharing

3: Run S3GBARandoApp.exe. It will use the changed locations when producing mod.gba
