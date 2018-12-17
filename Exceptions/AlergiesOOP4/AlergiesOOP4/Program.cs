using System;

namespace AlergiesOOP4
{
    public class Program
    {
        public static void Main()
        {
            Allergies obj = new Allergies();
            obj.Name = "Gina";
            obj.GetAllergens(25);
        }
    }
}
