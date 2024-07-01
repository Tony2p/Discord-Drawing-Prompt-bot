Project was made to extensively learn about object oriented programming in C#.

---------------------------------------------------------------------

On my discord server we often ran into the issue of not being able to come up with a topic to draw daily to.
So I decided to use that as an opportunity to write my own bot from scratch.

---------------------------------------------------------------------
First of all, I did create a JSON reader and encrypted the discord access key.

The main functions and commands are:

!prompt - gives a randomized prompt on what to draw. 
The values are stored in multiple arrays and are randomly selected and then printed by the bot in a discord channel. 
Due to different categories, I was able to minimize the length of the array while still offering an enourmous amount of options for a unique prompt.

!ref - This was another important command for me. It lists a bunch of art resources that I personally curated and are helpful for learning art or use as a reference.
I configured it into a format that displays interactable buttons that the user can press and get a response for a specific topic.
E.g if you press the anatomy button, you get a bunch of anatomy references and resources.

!pfp - A command that is able to access the profile picture of the user that is being tagged in combination with this command. 
Because we are an art server, there are a bunch of cool profile pictures that sometimes you'd like to view in a big picture format.

I added a lot more fluff into the bot to make it way more personal and with a bunch of easter eggs that are related to some of the users in the server!
