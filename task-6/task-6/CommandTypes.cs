namespace task_6
{
    /// <summary>
    /// The class  CommandTypes
    /// </summary>
    class CommandTypes : ICommand
    { 
        AllCommandClass types ;

        /// <summary>
        /// The constructor of  class
        /// </summary>
        /// <param name="types">brand of cars</param>
        public CommandTypes(AllCommandClass types)
        {
            this.types = types;
        }
        public void Execute()
        {
            types.Get_Types();
        }
    }
}
