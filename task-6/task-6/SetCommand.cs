namespace task_6
{
    /// <summary>
    /// The class SetCommand invoker
    /// </summary>
    class SetCommand
    {
        ICommand command;

        /// <summary>
        /// The constructor of  class
        /// </summary>
        /// <param name="command"></param>
        public SetCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// The method that call Execute()
        /// </summary>
        public void GetCommand()
        {
            command.Execute();
        }
    }
}
