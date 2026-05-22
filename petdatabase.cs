using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace PetsimulatorGUI
{
    public static class PetDatabase
    {
        public static Dictionary<string, (string PetName, int PetAge)> Data = new Dictionary<string, (string, int)>();

        public static string CurrentUsername { get; set; }
        public static string CurrentPetName { get; set; }
        public static int CurrentPetAge { get; set; }
    }
    public class PetInfo
    {
        public string PetName { get; set; }
        public int PetAge { get; set; }

        public PetInfo(string petName, int petAge)
        {
            PetName = petName;
            PetAge = petAge;
        }
    }
}


