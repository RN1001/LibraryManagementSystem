using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Data;

namespace LibraryManagementSystem.ViewModels
{
    class ManageBookViewModel
    {
        DBManager db;

        public void InsertBookQuery(TextBox title, TextBox pages, TextBox edition, TextBox cost, TextBox pubname, TextBox pubcity, TextBox pubyear, TextBox fname, TextBox mname, TextBox lname, TextBox genre, TextBox amount)
        {
            // use transaction to insert into copy table as well as other tables but let copyid auto increment.

            db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database, Please contact an Adminstrator.");
            }

            db.cmd = new MySqlCommand("InsertBooksp", db.Conn);

            db.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // book params
            db.cmd.Parameters.AddWithValue("title", title.Text);
            db.cmd.Parameters.AddWithValue("pages", pages.Text);
            db.cmd.Parameters.AddWithValue("edition", edition.Text);
            db.cmd.Parameters.AddWithValue("cost", cost.Text);

            // publisher params
            db.cmd.Parameters.AddWithValue("pubname", pubname.Text);
            db.cmd.Parameters.AddWithValue("pubcity", pubcity.Text);
            db.cmd.Parameters.AddWithValue("pubyear", pubyear.Text);

            // author params
            db.cmd.Parameters.AddWithValue("fname", fname.Text);
            db.cmd.Parameters.AddWithValue("lname", lname.Text);
            db.cmd.Parameters.AddWithValue("mname", mname.Text);

            // genre param
            db.cmd.Parameters.AddWithValue("genre", genre.Text);

            // copy param
            db.cmd.Parameters.AddWithValue("amount", amount.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        public void UpdateBookQuery()
        {
            db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database, Please contact an Adminstrator.");
            }

            string UpdateQuery = "";

            db.Conn.Close();
        }

        public void DeleteBookQuery()
        {
            db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database, Please contact an Adminstrator.");
            }

            string DeleteQuery = "";

            db.Conn.Close();
        }

        public void SearchBookById()
        {
            db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot connect to database, Please contact an Adminstrator.");
            }

            string SearchQuery = "";

            db.Conn.Close();
        }

        public void FillDgBookrecords(DataGrid grid)
        {
            DBManager db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            string getBookData = "SELECT Book.Lib_BookISBN AS isbn, Lib_BookTitle AS title, Lib_Bookpages AS Pages, Lib_BookEdition AS Edition, Lib_AuthorFirstname AS firstname, Lib_AuthorLastname AS lastname, Lib_PublisherName AS Publisher, Lib_PublishedYear AS year, Lib_GenreName AS genre, Lib_CopyAmount AS amount FROM book, author, publisher, genre, copy";

            db.cmd = new MySqlCommand(getBookData, db.Conn);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(db.cmd);

            DataTable records = new DataTable();

            dataAdapter.Fill(records);

            grid.DataContext = records;

            db.Conn.Close();
        }


    }
}
