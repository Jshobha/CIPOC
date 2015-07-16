using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class BaseClass: System.Web.UI.Page
{
    public BaseClass()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public virtual string getName()
    {
        string strName = string.Empty;

        strName = "Quinnox Consultancy Service Ltd.";

        return null;
    }

    public void WriteFile()
    {
        // Compose a string that consists of three lines.
        string lines = "First line.\r\nSecond line.\r\nThird line.";

        // Write the string to a file.
        //System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\HarisinghK\\Desktop\\CruiseControl.NET\\POCWriteFile.txt");
        System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\Shobhaj\\Desktop\\CruiseControl.NET\\POCWriteFile.txt");
        file.WriteLine(lines);

        file.Close();

    }
}