using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utility;
using LibraryManagementSystem.Models;
using MySql.Data.MySqlClient;
using System.Windows.Controls;
using System.Data;

namespace LibraryManagementSystem.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LibraryManagementSystem.Utility.ObservableObject" />
    class ManageLoansViewModel : ObservableObject
    {

        /// <summary>
        /// Searches the memory identifier.
        /// </summary>
        /// <param name="MemID">The memory identifier.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
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

        /// <summary>
        /// Searches the copy identifier.
        /// </summary>
        /// <param name="copyID">The copy identifier.</param>
        /// <param name="title">The title.</param>
        /// <param name="isbn">The isbn.</param>
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
                    System.Windows.Forms.MessageBox.Show("The Book Copy ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();
            }

        }

        /// <summary>
        /// Inserts the loan.
        /// </summary>
        /// <param name="memberid">The memberid.</param>
        /// <param name="copyid">The copyid.</param>
        /// <param name="fineid">The fineid.</param>
        /// <param name="stDate">The st date.</param>
        /// <param name="endDate">The end date.</param>
        public void InsertLoan(TextBox memberid, TextBox copyid, TextBox fineid, DatePicker stDate, DatePicker endDate)
        {
            DBManager db = new DBManager();

            try
            {
                db.Conn.Open();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Some form fields were not entered correctly, please resolve them before creating a loan.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
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

        public void FillDatagridFromLoanQuery(DataGrid grid)
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

            string getLoanData = "Select distinct Lib_LoanID AS ID, Lib_LoanStartDate AS Start_date, Lib_LoanEndDate AS End_Date, member.Lib_MemberFirstname as First_name, member.Lib_MemberLastname AS Last_name, Copy.Lib_BookISBN AS Copy_of_book, Book.Lib_BookTitle AS title, author.Lib_AuthorFirstname AS Author_firstname, author.Lib_AuthorLastname AS Author_lastname FROM loan, member, copy, book, author;";

            db.cmd = new MySqlCommand(getLoanData, db.Conn);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(db.cmd);

            DataTable records = new DataTable();

            dataAdapter.Fill(records);

            grid.DataContext = records;

            db.Conn.Close();
        }


    }
}
