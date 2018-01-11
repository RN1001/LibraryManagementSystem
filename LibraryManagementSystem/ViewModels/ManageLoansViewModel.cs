using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility;
using LibraryManagementSystem.Models;
using MySql.Data.MySqlClient;
using System.Windows.Controls;

namespace LibraryManagementSystem.ViewModels
{
    class ManageLoansViewModel : ObservableObject
    {

        public void SearchMemID(TextBox MemID, TextBox fname, TextBox lname)
        {
            DBManager db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Cannot connect to database, Please contact an Adminstrator.");
            }

            string SearchMemQuery = "SELECT Lib_MemberFirstname, Lib_MemberLastname FROM member WHERE Lib_MemberID = @MemID";

            db.cmd = new MySqlCommand(SearchMemQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@MemID", MemID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    fname.Text = (db.reader["Lib_MemberFirstname"]).ToString();
                    lname.Text = (db.reader["Lib_MemberLastname"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The member ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();
            }
        }

        public void SearchCopyID(TextBox copyID, TextBox title, TextBox isbn)
        {
            DBManager db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Cannot connect to database, Please contact an Adminstrator.");
            }

            string SearchBookCopyQuery = "SELECT distinct book.Lib_BookTitle AS bt, book.Lib_BookISBN AS isbn FROM copy, book WHERE book.Lib_BookISBN = @copyID";

            db.cmd = new MySqlCommand(SearchBookCopyQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@copyID", copyID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    title.Text = (db.reader["bt"]).ToString();
                    isbn.Text = (db.reader["isbn"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The member ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();
            }

        }

        public void InsertLoan(TextBox memberid, TextBox copyid, TextBox fineid, DatePicker stDate, DatePicker endDate)
        {
            DBManager db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("The member ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
            }

            db.cmd = new MySqlCommand("InsertLoansp", db.Conn);
            db.cmd.CommandType = System.Data.CommandType.StoredProcedure;

            db.cmd.Parameters.AddWithValue("@memberID", memberid.Text);
            db.cmd.Parameters.AddWithValue("@copyID", copyid.Text);
            db.cmd.Parameters.AddWithValue("@fineInc", fineid.Text);
            db.cmd.Parameters.AddWithValue("@stdate", stDate.Text);
            db.cmd.Parameters.AddWithValue("@enddate", endDate.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();

        }

    }
}
