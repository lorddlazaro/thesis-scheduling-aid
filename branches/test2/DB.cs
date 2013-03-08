using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace introse{
    class DB{
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;

        public DB(){
            init();
        }

        private void init(){
            server = "localhost";
            database = "introse";
            user = "root";
            password = "";

            connection = new MySqlConnection("SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";");
        }

        private bool OpenConnection(){
            try{
                connection.Open();
                return true;
            }
            catch (MySqlException ex){
                switch (ex.Number){
                    case 0:
                        MessageBox.Show("Cannot connect to server.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection(){
            try{
                connection.Close();
                return true;
            }
            catch (MySqlException ex){
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // ExecuteNonQuery: Used to execute a command that will not return any data, for example Insert, update or delete.
        public void executeNonQuery(String command){
            if (OpenConnection()){
                MySqlCommand cmd = new MySqlCommand(command, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        
        public void Insert(String query){
            executeNonQuery(query);
        }
        public void Update(String query){
            executeNonQuery(query);
        }
        public void Delete(String query){
            executeNonQuery(query);
        }


        // Not sure if we should use List <String>, alternatives include making use of 
        // the DataReader itself, the DataSet class or even ArrayList or something
        public List <string> [] Select(String query, int size){
            List< string >[] list = new List< string >[size];
            for(int i=0;i<size;++i)
                list[i] = new List< string >();

            if (OpenConnection()){
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
        
                while (dataReader.Read()){
                        for(int i=0;i<size;++i)
                            list[i].Add(dataReader[i] + "");
                }
                
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
                return list;
        }


        // ExecuteScalar: Used to execute a command that will return only 1 value, for example Select Count(*).
        public int ExecuteScalar(String query){
            if (OpenConnection()){
                MySqlCommand cmd = new MySqlCommand(query, connection);
                int num = int.Parse(cmd.ExecuteScalar()+"");
                this.CloseConnection();
                return num;
            }
            else
                return -1;
        }

        public int Count(String query){
            return ExecuteScalar(query);
        }
        public int Max(String query){
            return ExecuteScalar(query);
        }
        public int Min(String query){
            return ExecuteScalar(query);
        }

    }
}
