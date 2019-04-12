namespace task_6
{
    /// <summary>
    /// The class AllCommandClass
    /// </summary>
    class CommandCount : ICommand
    {
            Transport types;

        /// <summary>
        /// The constructor of  class
        /// </summary>
        /// <param name="types"></param>
        public CommandCount(Transport types)
            {
                this.types = types;
            }
            public void Execute()
            {
                types.Get_Count();
            }
    }
}
