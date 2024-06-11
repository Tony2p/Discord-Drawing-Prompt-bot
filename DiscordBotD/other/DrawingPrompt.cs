using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotD.other
{
    public class DrawingPrompt
    {
        //All the different prompts, can be added to.
        private string[] theme = {"Dark Fantasy", "Tribal", "Sci-Fi", "Cyberpunk",
            "Steampunk", "Medieval", "Modern", "Post-Apocalyptic", "Fantasy",
            "Horror", "Mystery", "Adventure", "Mythological", "Fairy Tale", "Wild West", "Atlantis", "Futuristic", };

        private string[] subject = { "Dragon", "Mermaid", "Knight", "Samurai", "Emperor", "Doctor", "Butler", "" };

        private string[] colorScheme = { "Grey", "Red", "Orange","Yellow", "Green", "Blue", "Violet",  };

        private string[] anatomyStudy = { "Heads", "Thoraxes", "Pelvis", "Arms", "Legs", "Hands", "Feet", "Hair", "Shoulders", "Abs", "Eyes", "Noses", "Mouths", "Expressions" };

        private string[] culture = {"American", "Brazil", "Arabian","Dutch", "Egyptian", "Gallic", "Greek", "Roman", "Indian",
            "Mongolian", "Ottoman", "Persian", "Polish", "Spanish", "Cree", "Aztec", "Native", "Japanese", "German", "French", "Bri ish", "Chinese",};

        private string[] universe = { "League of Legends", "Warcraft", "Star Wars", "Lord of the Rings", "Marvel/DC", "Pokemon", "Avatar",
            "Game of Thrones", "Minecraft", "Final Fantasy", "Zelda", "Harry Potter", "Street Fighter", "Dragon Ball", "Looney Tunes", "Starcraft",
        "Gundam"};
        
        private int[] timeLimit = { 5, 10, 15, 30, 45, 60, 120, 180 };


        public string Theme { get; set;}
        public string Subject { get; set;}
        public string ColorScheme { get; set;}
        public string AnatomyStudy { get; set;}
        public string Culture { get; set;}
        public string Universe { get; set;}
        public int TimeLimit { get; set;}




        //Prompt constructor and randomizer
        public DrawingPrompt()
        {
            
            var random = new Random();
            int themeIndex = random.Next(0, theme.Length);
            int subjectIndex = random.Next(0, subject.Length);
            int colorSchemeIndex = random.Next(0, colorScheme.Length);
            int anatomyStudyIndex = random.Next(0, anatomyStudy.Length);
            int cultureIndex = random.Next(0, culture.Length);
            int universeIndex = random.Next(0, universe.Length);
            int timeLimitIndex = random.Next(0, timeLimit.Length);

            this.Theme = theme[themeIndex];
            this.Subject = subject[subjectIndex];
            this.ColorScheme = colorScheme[colorSchemeIndex];
            this.AnatomyStudy = anatomyStudy[anatomyStudyIndex];
            this.Culture = culture[cultureIndex];
            this.Universe = universe[universeIndex];
            this.TimeLimit = timeLimit[timeLimitIndex];
            

        }


    }
}
