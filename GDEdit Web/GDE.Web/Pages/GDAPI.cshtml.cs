﻿using GDAPI.Application;
using GDAPI.Objects.GeometryDash.General;
using GDE.Web.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GDE.Web.Pages
{
    public class GDAPIModel : PageModel
    {
        private DatabaseCollection databaseCollection = new DatabaseCollection();
        private string levelString = "kS38,,kA13,0,kA15,0,kA16,0,kA14,,kA6,0,kA7,0,kA17,0,kA18,0,kS39,0,kA2,0,kA3,0,kA8,0,kA4,0,kA9,0,kA10,0,kA11,0;1,1,2,315,3,15,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1,2,345,3,15,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1004,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1716,2,375,3,1,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,7,2,465,3,15,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1,2,465,3,45,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1716,2,495,3,1,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1716,2,435,3,1,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1716,2,405,3,1,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1,2,555,3,15,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1719,2,585,3,4,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1716,2,525,3,1,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,36,99,0,117,0,13,0,2,675,3,45,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1719,2,615,3,4,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1719,2,675,3,4,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1719,2,645,3,4,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1720,2,765,3,4,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1719,2,705,3,4,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,1719,2,735,3,4,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,1010,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;1,111,13,0,2,975,3,75,4,0,5,0,6,0,32,1,20,0,61,0,24,0,25,0,21,0,22,0,57,,108,0,34,0,103,0,67,0,64,0,96,0,41,0,43,0a1a1a0a0,42,0,44,0a1a1a0a0,116,0,36,0;";

        public string LevelTitle;
        public string LevelDescription;
        public string LevelObjects;

        private Level level;

        public void OnGet()
        {
            GlobalVariables.CurrentSection = LinkItems.Levels;
            
            databaseCollection[0].UserLevels = new LevelCollection();

            level = databaseCollection[0].CreateLevel("Web Testing Level", "Testing purposes for the web!", levelString);
        
            LevelTitle = level.Name;
            LevelDescription = level.Description;
        
            LevelObjects = $"This has {level.ObjectCount} Objects with a length of {level.TimeLength:m\\:ss} ({level.Length})";
        }
    }
}