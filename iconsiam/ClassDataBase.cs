using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iconsiam {
    class ClassDataBase {



        //private readonly string CONFIG_SERVER = "192.168.9.14";
        private readonly string CONFIG_SERVER = "localhost";
        private readonly string CONFIG_UID = "iconsiam";
        private readonly string CONFIG_PASSWORD = "Rd123456!";
        private readonly string CONFIG_DATABASE = "iconsiam";


        private MySqlConnection MYSQL_CONNECTION;

        public ClassDataBase() {
            //Initialize();
            string connectionStr = "SERVER=" + CONFIG_SERVER + ";" + "DATABASE=" + CONFIG_DATABASE + ";" + "UID=" + CONFIG_UID + ";" + "PASSWORD=" + CONFIG_PASSWORD + ";SSLMODE=none;convert zero datetime=True";
            MYSQL_CONNECTION = new MySqlConnection(connectionStr);
            MYSQL_CONNECTION.Open();

        }

        private void Initialize() {

            try {
                if (this.MYSQL_CONNECTION.State != ConnectionState.Open) {
                    MYSQL_CONNECTION.Open();
                }
            }
            catch (MySqlException ex) {
                switch (ex.Number) {
                    case 0:
                        Debug.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Debug.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }
        }
        public void closeConnection() {
            this.MYSQL_CONNECTION.Close();
        }

        public DataTable getDataTable(string sql) {
            return this.fillDataTable(sql);
        }

        public DataRow getDataRow(string sql) {
            DataTable dataTable = this.fillDataTable(sql);
            if (dataTable.Rows.Count > 0) {
                return dataTable.Rows[0];
            }
            return null;
        }



        private DataTable fillDataTable(string sql) {

            if (this.MYSQL_CONNECTION.State != ConnectionState.Open ) {
                MYSQL_CONNECTION.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, this.MYSQL_CONNECTION)) {

                DataTable dataTable = new DataTable();
                dataTable.Load(cmd.ExecuteReader());
                return dataTable;
            }
        }


        public String selectOnceData(String table, String field, String where) {
            String strSql = "SELECT  " + field + " FROM  " + table + " WHERE  " + where;
            DataRow dr = getDataRow(strSql);

            if (dr == null) { return ""; }
            if (!string.IsNullOrEmpty(dr[field].ToString())) {
                return dr[field].ToString();
            }
            else return "";
        }

        public void updateData(Dictionary<string, string> fields, string tableName, string whereSql) {

            StringBuilder sqlUpdate = new StringBuilder();

            sqlUpdate.Append(" UPDATE `" + tableName+"`" );
            sqlUpdate.Append(" SET ");
            int countField = 0;
            foreach (KeyValuePair<string, string> pairKV in fields) {
                if (countField > 0) sqlUpdate.Append(" , ");
                if (!string.IsNullOrEmpty(pairKV.Value) && pairKV.Value.Trim().ToUpper().IndexOf("to_date".ToUpper()) > -1) {
                    sqlUpdate.Append(pairKV.Key + "=" + pairKV.Value.ToString() + "");
                }
                else {
                    sqlUpdate.Append(pairKV.Key + "='" + pairKV.Value + "'");
                }
                countField++;
            }

            if (!whereSql.Equals("")) {
                sqlUpdate.Append(" WHERE " + whereSql);
            }
            Debug.WriteLine("----->" + sqlUpdate);
            updateCommand(sqlUpdate.ToString());
            sqlUpdate.Clear();
        }

        public void updateCommand(string sqlUpdate) {
            if (this.MYSQL_CONNECTION.State != ConnectionState.Open) {
                MYSQL_CONNECTION.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sqlUpdate, this.MYSQL_CONNECTION);
            cmd.ExecuteNonQuery();
            Debug.WriteLine(sqlUpdate);
        }

        public void insertData(Dictionary<string, string> fields, string tableName) {
            StringBuilder sqlInsert = new StringBuilder();
            StringBuilder nameFileds = new StringBuilder();
            StringBuilder nameValues = new StringBuilder();

            sqlInsert.Append(" INSERT INTO `" + tableName+"` ");

            nameFileds.Append(" ( ");
            nameValues.Append(" ( ");
            int countField = 0;
            foreach (KeyValuePair<string, string> pairKV in fields) {
                if (countField > 0) {
                    nameFileds.Append(" , ");
                    nameValues.Append(" , ");
                }
                nameFileds.Append(pairKV.Key);

                if (!string.IsNullOrEmpty(pairKV.Value) && pairKV.Value.Trim().ToUpper().IndexOf("to_date".ToUpper()) > -1) {
                    nameValues.Append(pairKV.Value.ToString());
                }
                else {
                    nameValues.Append("'" + pairKV.Value + "'");
                }
                countField++;
            }
            nameFileds.Append(" ) ");
            nameValues.Append(" ) ");
            sqlInsert.Append(" " + nameFileds.ToString() + " VALUES " + nameValues);
            //Debug.WriteLine(sqlInsert.ToString());
            insertCommand(sqlInsert.ToString());


            sqlInsert.Clear();
        }

        public void insertCommand(string sqlInsert) {

            MySqlCommand cmd = new MySqlCommand(sqlInsert, this.MYSQL_CONNECTION);
            cmd.ExecuteNonQuery();
            Debug.WriteLine(sqlInsert);
        }

        public void deleteData(string tableName, string whereSql) {
            StringBuilder sqlDelete = new StringBuilder();
            sqlDelete.Append("DELETE FROM `" + tableName+"` ");
            sqlDelete.Append(" WHERE " + whereSql);
            this.updateCommand(sqlDelete.ToString());
            sqlDelete.Clear();
        }


        public string nextId(string tableName , string field) {
            string sql = "SELECT MAX(" + field + ")+1 as next_id FROM "+tableName;
            DataRow dr = getDataRow(sql);

            if (dr["next_id"].ToString().Equals("")) {
                return "1";
            }
            else {
                return dr["next_id"].ToString();
            }
            

        }




    }
}
