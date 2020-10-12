using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textfiles)
        {
            if(database == true)
            {
                //TODO- Create SQL Connection properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(textfiles == true)
            {
                //TODO- Create the Textfile Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
