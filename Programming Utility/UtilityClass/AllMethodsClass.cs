using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bhojarajsahu88.Programming_Utility.UtilityClass
{
    class AllMethodsClass
    {
        string connectionString = string.Empty;
        public AllMethodsClass()
        {
            connectionString = UtilityOperations.getConnectionString();
        }
        public bool checkUserLogin(string userId, string password, out int userDbKey)
        {
            string sqlstatement = null;
            userDbKey = 0;
            DataSet objDataSet = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    //sqlstatement = @"select * from login_info where userid = '" + userId + "' and userpassword='" + password + "' and Status = 'ACTIVE'";// Check user login details
                    sqlstatement = @"SELECT * FROM `user` where Email_Id = (SELECT userid FROM login_info where userid = '" + userId + "' and userpassword='" + password + "' and Status = 'ACTIVE')";
                    cmd.CommandText = sqlstatement;

                    cmd.Connection = con;
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(objDataSet);
                }
                if (objDataSet != null && objDataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = objDataSet.Tables[0].Rows[0];
                    userDbKey = Convert.ToInt32(dr["DbKey"].ToString());
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<PropertyClass> getResultList(string searchText, int categoryDbKey, int userId = 0)
        {
            List<PropertyClass> newList = new List<PropertyClass>();
            string sqlstatement = null;
            DataSet objDataSet = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    if (userId > 0)
                        sqlstatement = @"select * from article where Title like '%" + searchText + "%' and CategoryDbKey = " + categoryDbKey + " and CreatedBy = " + userId;// Check user login details
                    else
                        sqlstatement = @"select * from article where Title like '%" + searchText + "%' and CategoryDbKey = " + categoryDbKey + " and Status = 'ACTIVE'";// Check user login details
                    cmd.CommandText = sqlstatement;

                    cmd.Connection = con;
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(objDataSet);
                    foreach (DataRow dr in objDataSet.Tables[0].Rows)
                    {
                        PropertyClass newModel = new PropertyClass();
                        newModel.Id = Convert.ToInt32(dr["DbKey"]);
                        newModel.Title = dr["Title"].ToString();
                        newModel.ArticleType = dr["ArticleType"].ToString();
                        newModel.URL = dr["Url"].ToString();
                        //newModel.Code = dr["CODE"].ToString();
                        newList.Add(newModel);
                    }
                    return newList;
                }
            }
            catch (Exception ex)
            {
                return newList;
            }
        }
        public Dictionary<string, string> getCategoryList()
        {
            Dictionary<string, string> newList = new Dictionary<string, string>();
            string sqlstatement = null;
            DataSet objDataSet = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    sqlstatement = @"select DbKey,CategoryName,Status from category where Status = 'ACTIVE'";// Check user login details
                    cmd.CommandText = sqlstatement;

                    cmd.Connection = con;
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(objDataSet);
                    foreach (DataRow dr in objDataSet.Tables[0].Rows)
                    {
                        newList.Add(dr["CategoryName"].ToString(), dr["DbKey"].ToString());
                    }
                    return newList;
                }
            }
            catch (Exception ex)
            {
                return newList;
            }
        }
        public string getSingleCode(string DbKey)
        {
            string code = string.Empty;
            string sqlstatement = null;
            DataSet objDataSet = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    sqlstatement = @"select * from article_details where DbKey = " + DbKey + " and Status = 'ACTIVE'";// Check user login details
                    cmd.CommandText = sqlstatement;

                    cmd.Connection = con;
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(objDataSet);

                    if (objDataSet != null)
                    {
                        DataRow dr = objDataSet.Tables[0].Rows[0];
                        code = dr["ArticleDetails"].ToString();
                    }
                }
            }
            catch (Exception ex)
            { }
            return code;
        }

        public string getDbKey()
        {
            string code = string.Empty;
            string sqlstatement = null;
            DataSet objDataSet = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    sqlstatement = @"select DbKey from article order by DbKey desc";// Check user login details
                    cmd.CommandText = sqlstatement;

                    cmd.Connection = con;
                    MySqlDataAdapter da = new MySqlDataAdapter();

                    da.SelectCommand = cmd;
                    da.Fill(objDataSet);

                    if (objDataSet != null)
                    {
                        DataRow dr = objDataSet.Tables[0].Rows[0];
                        code = dr["DbKey"].ToString();
                    }
                }
            }
            catch (Exception ex)
            { }
            return code;
        }

        public bool addArticle(string article, string title, int categoryDbKey)
        {
            string sqlstatement = null;
            string url = title.ToLower();
            url = url.Replace(' ', '-');
            int status = 0;
            DataSet objDataSet = new DataSet();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    sqlstatement = @"insert into article (CategoryDbKey,ArticleType,Title,Url,MetaKeyWord,MetaDescription,CreatedBy, Status, CreatedOn, CreatedIP) 
                            values (" + categoryDbKey + ",'SNIPPET','" + title + "','" + url + "','" + title + "','" + title + "'," + UtilityOperations.getUserKey() + ",'INACTIVE',NOW(),'" + UtilityOperations.GetLocalIPAddress() + "')";// Check user login details
                    cmd.CommandText = sqlstatement;
                    cmd.Connection = con;
                    status = cmd.ExecuteNonQuery();
                }
                if (status > 0)
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string articleDbKey = getDbKey();
                        con.Open();
                        sqlstatement = @"insert into article_details (ArticleDbKey,ArticleDetails,Status, CreatedBy, CreatedIP, CreatedOn) 
                            values (" + articleDbKey + ",'" + article + "','ACTIVE','" + UtilityOperations.getUserKey() + "','" + UtilityOperations.GetLocalIPAddress() + "',NOW())";// Check user login details
                        cmd.CommandText = sqlstatement;
                        cmd.Connection = con;
                        status = cmd.ExecuteNonQuery();
                    }
                    if (status > 0)
                    {
                        using (MySqlConnection con = new MySqlConnection(connectionString))
                        {
                            string articleDbKey = getDbKey();
                            con.Open();
                            sqlstatement = @"insert into article_subcategory (ArticleDbKey,SubcategoryDbKey,Status, CreatedBy, CreatedIP, CreatedOn) 
                            values (" + articleDbKey + ",'" + 40 + "','ACTIVE','" + UtilityOperations.getUserKey() + "','" + UtilityOperations.GetLocalIPAddress() + "',NOW())";// Check user login details

                            sqlstatement = sqlstatement + ";" + @"insert into article_subcategory (ArticleDbKey,SubcategoryDbKey,Status, CreatedBy, CreatedIP, CreatedOn) 
                            values (" + articleDbKey + ",'" + 42 + "','ACTIVE','" + UtilityOperations.getUserKey() + "','" + UtilityOperations.GetLocalIPAddress() + "',NOW())";// Check user login details

                            cmd.CommandText = sqlstatement;
                            cmd.Connection = con;
                            status = cmd.ExecuteNonQuery();
                        }
                        if (status > 0)
                        {
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
