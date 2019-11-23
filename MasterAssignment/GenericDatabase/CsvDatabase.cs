using System;
using System.Collections.ObjectModel;
using System.IO;
using CommonFramework.Core;
using Contracts;


/*
 * Crystal Liles ~ 1 hour
 */

namespace GenericDatabase
{
    public class CsvDatabase : IFileReader
    {
        public string FilePath { get; set; }
        public bool Success { get; private set; }
        public string FailureMessage { get; private set; }
        public string DatabaseHeader { get; private set; }
        public Collection<EmployeeDataRecord> DatabaseRows { get; private set; }

        public void LoadDatabaseTable()
        {
            using (var sr = new StreamReader(FilePath))
            {
                DatabaseHeader = sr.ReadLine(); // remember: if you don't do this, then nothing else works!
                DatabaseRows = new Collection<EmployeeDataRecord>();
                try
                {
                    do
                    {
                        var oneLineOfText = sr.ReadLine();
                        if (oneLineOfText.IsNullOrEmpty()) break; // job done!
                        var oneLineParsedIntoArray = oneLineOfText.Split(separator: ',');
                        var oneLineParsedIntoStruct = new Contracts.EmployeeDataRecord
                        {
                            ID = oneLineParsedIntoArray[0].ToInt(), // ToInt is one of the CommonFramework.Core extensions
                            FName = oneLineParsedIntoArray[1],
                            MName = oneLineParsedIntoArray[2],
                            LName = oneLineParsedIntoArray[3],
                            Address = oneLineParsedIntoArray[4],
                            City = oneLineParsedIntoArray[5],
                            State = oneLineParsedIntoArray[6],
                            ZipCode = oneLineParsedIntoArray[7]
                        };
                        DatabaseRows.Add(oneLineParsedIntoStruct);
                    } while (true);
                    Success = true;
                }
                catch (Exception ex)
                {
                    // this is where the Success and FailureInformation properties are set.
                    FailureMessage = ex.Message;
                    Success = false;
                }
            }
        }
    }
}
