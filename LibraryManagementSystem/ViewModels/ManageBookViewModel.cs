using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility;
using System.Windows.Forms;

namespace LibraryManagementSystem.ViewModels
{
    class ManageBookViewModel
    {
        DBManager db;

        public void InsertBookQuery()
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

            string InsertQuery = "";

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

    }
}
