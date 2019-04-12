namespace task_6
{
    /// <summary>
    /// The class CommandAveragePrice
    /// </summary>
    class CommandAveragePrice : ICommand
    {
        Transport types;
        public CommandAveragePrice(Transport types)
        {
            this.types = types;
        }
        public void Execute()
        {
            types.Get_AveragePrice();
        }
    }
}
