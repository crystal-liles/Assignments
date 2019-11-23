using System.Collections.ObjectModel;

namespace Contracts
{
    public interface IFileReader
    {
        /// <summary>
        /// property used to pass the starting-point file path and return the final
        /// file path selected
        /// </summary>
        string FilePath { get; set; }

        /// <summary>
        /// means of communicating the success of the operation
        /// </summary>
        bool Success { get; }

        /// <summary>
        /// means of communicating the problem encountered
        /// </summary>
        string FailureMessage { get; }

        /// <summary>
        ///Loads the database into a typed array
        /// </summary>
        void LoadDatabaseTable();

        /// <summary>
        /// A single string containing the database header as a string
        /// </summary>
        string DatabaseHeader { get; }

        /// <summary>
        /// The resultant file data content
        /// </summary>
        
        Collection<EmployeeDataRecord> DatabaseRows { get; }
    }
}