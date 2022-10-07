namespace KowalskiApp.StdLibrary.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName}";
        }
    }
}