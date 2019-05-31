namespace task_6
{
    /// <summary>
    /// The class AllCommandClass
    /// </summary>
    class CommandCount : ICommand
    {
            AllCommandClass types;

        /// <summary>
        /// The constructor of  class
        /// </summary>
        /// <param name="types"></param>
        public CommandCount(AllCommandClass types)
            {
                this.types = types;
            }
            public void Execute()
            {
                types.Get_Count();
            }
    }
}
