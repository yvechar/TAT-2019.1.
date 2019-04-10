namespace task_6
{
    /// <summary>
    /// The class CommandAveragePrice
    /// </summary>
    class CommandAveragePrice : ICommand
    {
        AllCommandClass types;
        public CommandAveragePrice(AllCommandClass types)
        {
            this.types = types;
        }
        public void Execute()
        {
            types.Get_AveragePrice();
        }
    }
}
