namespace AbstractDP10.Factory.AbstractFactory
{
    /// <summary>
    /// Employee System Manager
    /// </summary>
    public class EmployeeSystemManager
    {
        /// <summary>
        /// The computer factory
        /// </summary>
        private IComputerFactory computerFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeSystemManager"/> class.
        /// </summary>
        /// <param name="computerFactory">The computer factory.</param>
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }

        /// <summary>
        /// Gets the system details.
        /// </summary>
        /// <returns></returns>
        public string GetSystemDetails()
        {
            IBrand brand = this.computerFactory.Brand();
            IProcessor processor = this.computerFactory.Processor();
            ISystemType systemType = this.computerFactory.SystemType();

            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(), processor.GetProcessor(), systemType.GetSystemType());
            return returnValue;
        }
    }
}
