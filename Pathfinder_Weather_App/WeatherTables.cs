using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_Weather_App
{
    static class WeatherTables
    {
        public static List<string> intensities = new List<string> { "Light", "Medium", "Heavy", "Torrential" };

        public static List<string> timeOfDay = new List<string> { "Morning", "Midday", "Evening", "Night" };

        public static Dictionary<string, int> freqDictionary = new Dictionary<string, int>
        {
            { "Default", -1 },
            { "None", 0 },
            { "Drought", 5 },
            { "Rare", 15 },
            { "Intermittent", 30 },
            { "Common", 60 },
            { "Constant", 95 }
        };

        public static Dictionary<int, (int, int, int)> coldDictionary = new Dictionary<int, (int, int, int)>
        {
            {20, (-3 , 1, 4) },
            {40,  (-2, 2, 7) },
            {60, (-1, 3, 8) },
            {80, (0, 3, 8) },
            {95, (1, 2, 7) },
            {99, (2, 1, 4) },
            {100, (3, 1, 2) }
        };

        public static Dictionary<int, (int, int, int)> tempDictionary = new Dictionary<int, (int, int, int)>
        {
            {5, (-3, 1, 2) },
            {15, (-2, 1, 4) },
            {35, (-1, 2, 5) },
            {65, (0, 2, 7) },
            {85, (1, 2, 5) },
            {95, (2, 1, 4) },
            {100, (3, 1, 2) }
        };

        public static Dictionary<int, (int, int, int)> tropDictionary = new Dictionary<int, (int, int, int)>
        {
            {10, (-2, 1, 2) },
            {25,  (-1, 1, 2) },
            {55,  (0, 1, 4) },
            {85, (1, 1, 4) },
            {100, (2, 1, 2) },
        };

        public static Dictionary<int, (string, int, int)> LightUnfrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {20, ("Light Fog", 1,8) },
            {40, ("Medium Fog", 1,6) },
            {50, ("Drizzle", 1,4) },
            {75, ("Drizzle", 2,24) },
            {90, ("Light Rain", 1,4) },
            {100, ("Light Rain", 1,1) }
        };

        public static Dictionary<int, (string, int, int)> LightFrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {20, ("Light Fog", 1,6) },
            {40, ("Light Fog", 1,8) },
            {50, ("Medium Fog", 1,4) },
            {60, ("Light Snow", 1,1) },
            {75, ("Light Snow", 1,4) },
            {100, ("Light Snow", 2,24) }
        };

        public static Dictionary<int, (string, int, int)> MediumUnfrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {10, ("Medium Fog", 1,8) },
            {20, ("Medium Fog", 1,12) },
            {30, ("Heavy Fog", 1,4) },
            {35, ("Rain", 1,4) },
            {70, ("Rain", 1,8) },
            {90, ("Rain", 2,24) },
            {100, ("Rain", 1,4) }
        };

        public static Dictionary<int, (string, int, int)> MediumFrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {10, ("Medium Fog", 1,6) },
            {20, ("Medium Fog", 1,8) },
            {30, ("Heavy Fog", 1,4) },
            {50, ("Medium Snow", 1,4) },
            {90, ("Medium Snow", 1,8) },
            {100, ("Medium Snow", 2,24) }
        };

        public static Dictionary<int, (string, int, int)> HeavyUnfrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {10, ("Heavy Fog", 1,8) },
            {20, ("Heavy Fog", 2,12) },
            {50, ("Heavy Rain", 1,12) },
            {70, ("Heavy Rain", 2,24) },
            {85, ("Heavy Rain", 1,8) },
            {90, ("Thunderstorm", 1,1) },
            {100, ("Thunderstorm", 1,3) }
        };

        public static Dictionary<int, (string, int, int)> HeavyFrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {10, ("Medium Fog", 1,8) },
            {20, ("Heavy Fog", 2,12) },
            {60, ("Light Snow", 2,24) },
            {90, ("Medium Snow", 1,8) },
            {100, ("Heavy Snow", 1,6) }
        };

        public static Dictionary<int, (string, int, int)> TorrentialUnfrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {5, ("Heavy Fog", 1,8) },
            {10, ("Heavy Fog", 2,12) },
            {30, ("Heavy Rain", 2,12) },
            {60, ("Heavy Rain", 2,24) },
            {80, ("Heavy Rain", 2,12) },
            {95, ("Thunderstorm", 1,3) },
            {100, ("Thunderstorm", 1,6) }
        };

        public static Dictionary<int, (string, int, int)> TorrentialFrozenDictionary = new Dictionary<int, (string, int, int)>
        {
            {5, ("Heavy Fog", 1,8) },
            {10, ("Heavy Fog", 2,12) },
            {50, ("Heavy Snow", 1,4) },
            {90, ("Heavy Snow", 1,83) },
            {100, ("Heavy Snow", 2,24) }
        };

        public static Dictionary<int, (string, int, int)>[,] EventTables = new Dictionary<int, (string, int, int)>[2, 4]
        {
            {LightUnfrozenDictionary,MediumUnfrozenDictionary,HeavyUnfrozenDictionary,TorrentialUnfrozenDictionary },
            {LightFrozenDictionary, MediumFrozenDictionary,HeavyFrozenDictionary,TorrentialFrozenDictionary }
        };

        public static Dictionary<string, (string, int, string, bool)> Mechanics = new Dictionary<string, (string, int, string, bool)>
        {
            {"Drizzle",("3/4", -2, "Extinguishes tiny unprotected flames", true) },
            {"Heavy Fog", ("5 feet, after which concealment", 0, "", false) },
            {"Light Fog", ("3/4", -2, null, false) },
            {"Medium Fog", ("1/2", -4 , null, false) },
            {"Rain", ("1/2", -4, "Extinguishes all unprotected flames", true) },
            {"Heavy Rain", ("1/4", -6, "Extinguishes all unprotected flames", true) },
            {"Heavy Snow", ("1/4", -6, "Difficult terrain. Extinguishes all unprotected flames", true)},
            {"Light Snow", ("3/4", -2, null, true) },
            {"Medium Snow", ("1/2", -4, "Difficult terrain", true) },
            {"Thunderstorm", ("1/4", -6, "Concentration DC 15 + spell. Extinguishes all unprotected flames", true) }
        };

        public static Dictionary<int, string> Clouds = new Dictionary<int, string>
        {
            {50, "None" },
            {70, "Light Clouds" },
            {85, "Medium Clouds" },
            {100, "Overcast" }
        };

        public static Dictionary<int, (string, int, int, int, string, string, int)> Winds = new Dictionary<int, (string, int, int, int, string, string, int)>
        {
            {50, ("Light", 0, 10, 0, "None", "None", 0 ) },
            {80, ("Moderate", 11, 20, 0, "None", "None", 0 ) },
            {90, ("Strong", 21, 30, -2, "Tiny", "None", -2 ) },
            {95, ("Severe", 31, 50, -4, "Small", "Tiny", -4 ) },
            {100, ("Windstorm", 51, 231, -50, "Medium", "Small", -8 ) }
        };
    }
}
