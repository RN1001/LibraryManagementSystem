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
    /// <summary>
    /// 
    /// </summary>
    class ManageBookViewModel
    {
        /// <summary>
        /// The database
        /// </summary>
        DBManager db;

        /// <summary>
        /// Inserts a book query, uses a stored procedure from MYSQL
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="pages">The pages.</param>
        /// <param name="edition">The edition.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="pubname">The pubname.</param>
        /// <param name="pubcity">The pubcity.</param>
        /// <param name="pubyear">The pubyear.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="mname">The mname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="genre">The genre.</param>
        /// <param name="amount">The amount.</param>
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

        /// <summary>
        /// Updates the book query.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <param name="title">The title.</param>
        /// <param name="pages">The pages.</param>
        /// <param name="edition">The edition.</param>
        /// <param name="cost">The cost.</param>
        public void UpdateBookQuery(TextBox isbn, TextBox title, TextBox pages, TextBox edition, TextBox cost)
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

            string UpdateQuery = "UPDATE books SET Lib_BookTitle = @title, Lib_Bookpages = @pages, Lib_BookEdition = @edition, Lib_BookCost = @cost WHERE .Lib_BookISBN = @isbn";

            db.cmd = new MySqlCommand(UpdateQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@isbn", isbn.Text);
            db.cmd.Parameters.AddWithValue("@title", title.Text);
            db.cmd.Parameters.AddWithValue("@pages", pages.Text);
            db.cmd.Parameters.AddWithValue("@edition", edition.Text);
            db.cmd.Parameters.AddWithValue("@cost", cost.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Deletes a book record.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        public void DeleteBookQuery(TextBox isbn)
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

            string DeleteQuery = "DELETE FROM books WHERE Lib_bookISBN = @isbn";

            db.cmd = new MySqlCommand(DeleteQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@isbn", isbn.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Searches the book by identifier.
        /// </summary>
        /// <param name="bookID">The book identifier.</param>
        /// <param name="title">The title.</param>
        /// <param name="pages">The pages.</param>
        /// <param name="edition">The edition.</param>
        /// <param name="cost">The cost.</param>
        public void SearchBookById(TextBox bookID, TextBox title, TextBox pages, TextBox edition, TextBox cost)
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

            string SearchQuery = "SELECT Lib_BookTitle, Lib_BookPages, Lib_BookEdition, Lib_BookCost FROM books WHERE Lib_BookISBN = @bookID";

            db.cmd = new MySqlCommand(SearchQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@BookID", bookID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    title.Text = (db.reader["Lib_BookTitle"]).ToString();
                    pages.Text = (db.reader["Lib_BookPages"]).ToString();
                    edition.Text = (db.reader["Lib_BookEdition"]).ToString();
                    cost.Text = (db.reader["Lib_BookCost"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The Book Copy ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();

            }
        }

        /// <summary>
        /// Updates a publisher record.
        /// </summary>
        /// <param name="pubID">The pub identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="year">The year.</param>
        public void UpdatePublisherQuery(TextBox pubID, TextBox name, TextBox city, TextBox year)
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

            string UpdateQuery = "UPDATE publishers SET Lib_PublisherName = @name, Lib_PublisherCity = @city, Lib_PublishedYear = @year WHERE Lib_PublisherID = @pubID";

            db.cmd = new MySqlCommand(UpdateQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@pubID", pubID.Text);
            db.cmd.Parameters.AddWithValue("@name", name.Text);
            db.cmd.Parameters.AddWithValue("@city", city.Text);
            db.cmd.Parameters.AddWithValue("@year", year.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Deletes a publisher record.
        /// </summary>
        /// <param name="pubID">The pub identifier.</param>
        public void DeletePublisherQuery(TextBox pubID)
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

            string DeleteQuery = "DELETE FROM publisher WHERE Lib_PublisherID = @pubID";

            db.cmd = new MySqlCommand(DeleteQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@pubID", pubID.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Searches the publisher by identifier.
        /// </summary>
        /// <param name="pubID">The pub identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="city">The city.</param>
        /// <param name="year">The year.</param>
        public void SearchPublisherById(TextBox pubID, TextBox name, TextBox city, TextBox year)
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

            string SearchMemQuery = "SELECT Lib_PublisherName, Lib_PublisherCity, Lib_PublishedYear FROM publishers WHERE Lib_PublisherID = @pubID";

            db.cmd = new MySqlCommand(SearchMemQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@pubID", pubID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    name.Text = (db.reader["Lib_PublisherName"]).ToString();
                    city.Text = (db.reader["Lib_PublisherCity"]).ToString();
                    year.Text = (db.reader["Lib_PublishedYear"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The Publisher ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();
            }
        }

        /// <summary>
        /// Updates an author record.
        /// </summary>
        /// <param name="authorID">The author identifier.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="mname">The mname.</param>
        /// <param name="lname">The lname.</param>
        public void UpdateAuthorQuery(TextBox authorID, TextBox fname, TextBox mname, TextBox lname)
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

            string UpdateQuery = "UPDATE authors SET Lib_AuthorFirstname = @fname, Lib_AuthorMiddleName = @mname, Lib_AuthorLastname = @lname WHERE Lib_AuthorID = @authorID";

            db.cmd = new MySqlCommand(UpdateQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@authorID", authorID.Text);
            db.cmd.Parameters.AddWithValue("@fname", fname.Text);
            db.cmd.Parameters.AddWithValue("@mname", mname.Text);
            db.cmd.Parameters.AddWithValue("@lname", lname.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Deletes an author record.
        /// </summary>
        /// <param name="authorID">The author identifier.</param>
        public void DeleteAuthorQuery(TextBox authorID)
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

            string DeleteQuery = "DELETE FROM authors WHERE Lib_AuthorID = @authorID";

            db.cmd = new MySqlCommand(DeleteQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@authorID", authorID.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Searches the author by identifier.
        /// </summary>
        /// <param name="authorID">The author identifier.</param>
        /// <param name="fname">The fname.</param>
        /// <param name="mname">The mname.</param>
        /// <param name="lname">The lname.</param>
        public void SearchAuthorById(TextBox authorID, TextBox fname, TextBox mname, TextBox lname)
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

            string SearchQuery = "SELECT Lib_AuthorFirstname, Lib_AuthorMiddleName, Lib_AuthorLastname FROM authors WHERE Lib_AuthorID = @authorID";

            db.cmd = new MySqlCommand(SearchQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@authorID", authorID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    fname.Text = (db.reader["Lib_AuthorFirstname"]).ToString();
                    mname.Text = (db.reader["Lib_AuthorMiddleName"]).ToString();
                    lname.Text = (db.reader["Lib_AuthorLastname"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The Author ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();

            }
        }

        /// <summary>
        /// Updates an genre record.
        /// </summary>
        /// <param name="genreID">The genre identifier.</param>
        /// <param name="genreName">Name of the genre.</param>
        public void UpdateGenreQuery(TextBox genreID, TextBox genreName)
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

            string UpdateQuery = "UPDATE genre SET Lib_GenreName WHERE Lib_GenreID = @genreID";

            db.cmd = new MySqlCommand(UpdateQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@genreID", genreID.Text);
            db.cmd.Parameters.AddWithValue("@genreName", genreName.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Deletes an genre record.
        /// </summary>
        /// <param name="genreID">The genre identifier.</param>
        public void DeleteGenreQuery(TextBox genreID)
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

            string DeleteQuery = "DELETE FROM genre WHERE Lib_GenreID = @genreID";

            db.cmd = new MySqlCommand(DeleteQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@genreID", genreID.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Searches the genre by identifier.
        /// </summary>
        /// <param name="genreID">The genre identifier.</param>
        /// <param name="genreName">Name of the genre.</param>
        public void SearchGenreById(TextBox genreID, TextBox genreName)
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

            string SearchMemQuery = "SELECT Lib_GenreName FROM genre WHERE Lib_GenreID = @genreID";

            db.cmd = new MySqlCommand(SearchMemQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@MemID", genreID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    genreName.Text = (db.reader["Lib_GenreName"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The Genre ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();
            }
        }

        /// <summary>
        /// Updates a copy record.
        /// </summary>
        /// <param name="copyID">The copy identifier.</param>
        /// <param name="amount">The amount.</param>
        public void UpdateCopyQuery(TextBox copyID, TextBox amount)
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

            string UpdateQuery = "UPDATE copy SET Lib_CopyAmount = @amount WHERE Lib_CopyID = @copyID";

            db.cmd = new MySqlCommand(UpdateQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@copyID", copyID.Text);
            db.cmd.Parameters.AddWithValue("@amount", amount.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Deletes a copy record.
        /// </summary>
        /// <param name="copyID">The copy identifier.</param>
        public void DeleteCopyQuery(TextBox copyID)
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

            string DeleteQuery = "DELETE FROM copy WHERE Lib_CopyID = @copyID";

            db.cmd = new MySqlCommand(DeleteQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@copyID", copyID.Text);

            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        /// <summary>
        /// Searches the copy by identifier.
        /// </summary>
        /// <param name="copyID">The copy identifier.</param>
        /// <param name="amount">The amount.</param>
        public void SearchCopyById(TextBox copyID, TextBox amount)
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

            string SearchMemQuery = "SELECT Lib_CopyAmount FROM copy WHERE Lib_CopyID = @copyID";

            db.cmd = new MySqlCommand(SearchMemQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@copyID", copyID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    amount.Text = (db.reader["Lib_CopyAmount"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The Book Copy ID was incorrect, please make sure that the ID is a number.", "Data retrival error", System.Windows.Forms.MessageBoxButtons.OK);
                }

                db.Conn.Close();

            }
        }

        /// <summary>
        /// Fills the datagrid on mainwindow form with book records.
        /// </summary>
        /// <param name="grid">The grid.</param>
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

            string getBookData = "SELECT B.Lib_BookISBN AS isbn, B.Lib_BookTitle AS title, B.Lib_Bookpages AS Pages, B.Lib_BookEdition AS Edition, A.Lib_AuthorFirstname AS firstname, A.Lib_AuthorLastname AS lastname, P.Lib_PublisherName AS Publisher, P.Lib_PublishedYear AS year, G.Lib_GenreName AS genre, C.Lib_CopyAmount AS amount " +
                " FROM book B "+
                "inner join authorbook AB on B.Lib_BookISBN = AB.Lib_BookISBN " +
                "inner join author A on AB.Lib_AuthorID = A.Lib_AuthorID" +
                "inner join publisher P on B.Lib_PublisherID = P.Lib_PublisherID " +
                "inner join genre G on B.Lib_GenreID = G.Lib_GenreID " +
                "inner join copy C on B.Lib_BookISBN = C.Lib_BookISBN; ";

            db.cmd = new MySqlCommand(getBookData, db.Conn);

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(db.cmd);

            DataTable records = new DataTable();

            dataAdapter.Fill(records);

            grid.DataContext = records;

            db.Conn.Close();
        }


    }
}
