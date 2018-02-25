namespace ConsoleApp3
{
    interface IAnimals
    {
        string AnimalName { get; }
        int LegsCount { get; }
        bool WithTail { get; }
        void Action();
    }
}
