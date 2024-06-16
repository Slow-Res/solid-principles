using SingleResponsibilityPrinciple.SOLID;
using System;
using System.Diagnostics;

var journals = new Journal();

journals.AddEntry("Dummy Entry 1");
journals.AddEntry("Dummy Entry 2");
journals.AddEntry("Dummy Entry 3");

System.Console.WriteLine(journals);

var persist = new Persistence();
var filePath = @"SingleResponsibilities\journal.txt";
persist.SaveToFile(journals, filePath);
Process.Start("notepad.exe", filePath);
