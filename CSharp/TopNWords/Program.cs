﻿namespace Microsoft.Azure.Batch.Samples.TopNWordsSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //We share the same EXE for both the main program and the task
            //Decide which one to start based on the command line parameters
            if (args != null && args.Length > 0 && args[0] == "--Task")
            {
                TopNWordsTask.TaskMain(args);
            }
            else
            {
                Job.JobMain(args);
            }
        }
    }
}
