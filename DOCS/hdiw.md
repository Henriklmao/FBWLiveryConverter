# How does the Livery Converter work.

### How does it check if a livery is valid or not.
It is checking if there's a manifest.json in the directory of the livery.
> if (File.Exists(lvrdir + "/manifest.json"))
This seems quite primitive, but it protects the user from selecting the wrong directory $(i.e. the directory of the livery inside of the Simobjects$\Airplanes%\ folder$).

### How does it convert the livery to be compatible with the A32nx mod?
Basically it just replaces some lines of code where Asobo_A320_Neo is with FlyByWire_A320_Neo. It is pretty easy to do by hand but why should you be doing it by hand if there's a program for that, right?

### More info

#### How's the GUI made?
We basically used the $(.net$)Windows-Forms Designer from Visual Studios. Special thanks to skyline for doing the design as I am pretty bad at that.