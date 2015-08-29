# Plex2Sonos

What is it:

A Proxy Server that implements the Sonos Music SOAP API and forwards requests to Plex.

Why I did it:

I love Plex, I have all of my play lists stored on it and I have a Plex Pass which gets all this great metadata about the artists.  I tried SubSonic, meh.. didn't really want to switch over to it
just for music.  Plus I didn't like how they did everything by directory name.

Where I'm at right now:

Well, it took about 2 hours to get one song to play through the system, but it was a total hack job.  To actually get the browsing going, artwork, etc, it took some work.  I have about a billion things
left to do and I need to redo 99% of the code base.  I've done like zero testing, hence no unit tests, hence the reason why I'm going to rewrite it.

What you can do:

Browse and play music.. no searching, but that is pretty easy to do.. no play lists.. again should be easy..

What I need to do:

Search
Play Lists (the main reason why I did this)
Dynamic Play Lists (Year, Genre, Etc)
Plex Native Play Lists (Recently Added etc..)
Auto Registration with Sonos
Smart Updating of Plex2Sonos DB or think about just going against Plex, the problem is Sonos wants "Total Counts" of everything so it can do proper paging.. I don't think Plex API has that.
I know there is an issue with mime-types being set incorrectly.
Remove dependencies on Linq for navigating with SelectMany.. that has to suck with larger collections
Add Unit Tests (Duh)
Figure out why the F I can't get proper display on the actual track time and duration, and album art and artist name and album name.. I set it all (IOS App, I assume others as well)
Shorten Key Names
Add "Related Artists, etc"
Dig Deeper into ExtendedMetaData
Handle Multiple Music Collections
Work with External Plex Servers??
Work with Multiple Plex Servers??
Look at Authentication for differnet local users, so you have different play lists..
Create, Edit, Delete?? Play Lists
Favorites
Ratings
Scrolling Support
Custom Icons for app
Shrink Images for proper sizing on the fly
Strings and Maps
Caching options on Sonos
Caching options with images..??
Add as Windows Service (should be easy)
Port to Node 
Create a docker image and let this run on Mono before it gets ported..
Logging
Exception Handling
About a billion other things, but this is just a POC

What you need to do to get this to work
(Compile it, .NET 4.6 and make sure you do it in release mode, DynamicRestProxy is slow in debug mode with or without debugger)
Register it with Sonos 
http://<YOURSONOSBOX>:1400/customsd.htm

SID, pick anything, I took 249
ServiceName: Plex2Sonos
EndPointUrl: http://<IP OF WHERE YOU RUN THE CONSOLE APP>:8888/Plex2Sonos
Secure EndPointUrl: http://<IP OF WHERE YOU RUN THE CONSOLE APP>:8888/Plex2Sonos
Pooling Interval: 60 Seconds
Container Type: Music Service
Auth: Anonymous (for now)
Leave Strings and Maps empty.. I know what I need to do there..

Check the following (more to come soon)
Extended Metadata (for MOAPI-based InfoView)
Disable Multiple Account Support

Start the Console App, Add the service to Sonos.. Pray..

I'M NOT SURE IF THIS WILL WORK IF YOU DON'T HAVE PLEX PASS.. IT SHOULD BUT I HAVEN'T TESTED

