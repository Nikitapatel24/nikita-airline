using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;



public class SqlHelper
{
    
    private static String getConnectionString()
    {
        //build up the connection string for the sql server database
        return "Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + GetDBName() + ";Integrated Security=True;Connect Timeout=30";
    }

    private static string GetDBName()
    {
        //var to store the base dir of the site
        string BaseDir;
        //list to store final list of files found (should only be one!)
        List<string> DBNames = new List<string>();
        //get the base dir
        BaseDir = System.AppDomain.CurrentDomain.BaseDirectory + "App_Data";
        //get the list of files in the app_data folder
        string[] filePaths = System.IO.Directory.GetFiles(BaseDir, "*.mdf", System.IO.SearchOption.AllDirectories);
        //counter for the loop
        Int32 Counter = 0;
        //while there are files to process
        while (Counter < filePaths.Length)
        {
            //if the file is not a system database file
            if (filePaths[Counter].Contains("ASPNETDB.MDF") == false)
            {
                //add the file to the list of db names
                DBNames.Add(filePaths[Counter]);
            }
            //inc the counter
            Counter++;
        }

        if (DBNames.Count == 1)
        {
            //return the full path of the db
            return DBNames[0];
        }
        //if no database is founjd throw an exception
        else if (DBNames.Count == 0)
        {
            throw new System.Exception("There is no database in your App_Data folder");
        }
        //if multiple database have been found throw an error
        else
        {
            throw new System.Exception("You have too many database files in your App_Data folder");
        }

    }

    public static Int32 Execute(string SProcName, Dictionary<String, String> param)
    {
        ///public method used to execute the named stored procedure
        ///accepts one parameter which is the name of the stored procedure to use
        /// and a dictionay of params
        //open the stored procedure
        //initialise the connection to the database
        SqlConnection connectionToDB = new SqlConnection(getConnectionString());

        //open the database
        connectionToDB.Open();

        //initialise the command builder for this connection
        SqlCommand dataCommand = new SqlCommand(SProcName, connectionToDB);

        //add the parameters to the command builder
        //loop through each parameter
        foreach(String key in param.Keys)
        {
            //add it to the command builder
            dataCommand.Parameters.Add(new  SqlParameter(key, param[key]));
        }

        //create an instance of the SqlParameter class
        SqlParameter returnValue = new SqlParameter();
        
        //set the direction as the return value
        returnValue.Direction = ParameterDirection.ReturnValue;
        //add this parameter to the Command builder
        
        dataCommand.Parameters.Add(returnValue);
        
        //set the command type as stored procedure
        dataCommand.CommandType = CommandType.StoredProcedure;
        
        //execute the stored procedure
        try
        {
            dataCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Error = " + ex.ToString());
            //   throw new System.Exception("Could not get the data.  Check that you have the correct name for your stored procedure.");
        }
        //close the connection
        connectionToDB.Close();
        //return the result of the stored procedure
        return Convert.ToInt32(returnValue.Value);
    }
    public static DataTable ExecuteQuerySP(string SProcName, Dictionary<String, String> param)
    {
        ///public method used to execute the named stored procedure
        ///accepts one parameter which is the name of the stored procedure to use
        /// and a dictionay of params
        //open the stored procedure
        //initialise the connection to the database
        SqlConnection connectionToDB = new SqlConnection(getConnectionString());

        //open the database
        connectionToDB.Open();

        //initialise the command builder for this connection
        SqlCommand dataCommand = new SqlCommand(SProcName, connectionToDB);

        //add the parameters to the command builder
        //loop through each parameter
        foreach (String key in param.Keys)
        {
            //add it to the command builder
            dataCommand.Parameters.Add(new SqlParameter(key, param[key]));
        }

        //create an instance of the SqlParameter class
        SqlParameter returnValue = new SqlParameter();

        //set the direction as the return value
        returnValue.Direction = ParameterDirection.ReturnValue;
        //add this parameter to the Command builder

        dataCommand.Parameters.Add(returnValue);

        //set the command type as stored procedure
        dataCommand.CommandType = CommandType.StoredProcedure;

        //initialise the data adapter
        SqlDataAdapter dataChannel = new SqlDataAdapter(SProcName, connectionToDB);
        //set the select command property for the data adapter
        dataChannel.SelectCommand = dataCommand;
        //use the copmmand builder to generate the sql insert delete etc
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataChannel);
        

        //data set 
        DataTable ds = new DataTable("temp");

        //fill the data adapter
        try
        {
            dataChannel.Fill(ds);
        }
        catch (Exception ex)
        {
            throw new Exception("Error = " + ex.ToString());
            //   throw new System.Exception("Could not get the data.  Check that you have the correct name for your stored procedure.");
        }
        //close the connection
        connectionToDB.Close();
        //return the result of the stored procedure
        return ds;
    }

   
}
