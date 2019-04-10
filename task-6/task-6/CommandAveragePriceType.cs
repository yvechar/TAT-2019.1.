namespace task_6
{
    /// <summary>
    /// The class CommandAveragePriceType
    /// </summary>
    class CommandAveragePriceType
    {
        AllCommandClass types;
        public CommandAveragePriceType(AllCommandClass types)
        {
            this.types = types;
        }
        public void Execute()
        {
            types.Get_AveragePriceType();
        }
    }
}
