using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utility;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using LibraryManagementSystem.Views;
using System.Windows.Controls;

namespace LibraryManagementSystem.ViewModels
{
    class ManageMemberViewModel : ObservableObject
    {
        #region Model Wrapper Properties

        // region could move to another class for reading or updating data.

        Member member = new Member();

        public string Firstname
        {
            get { return member.MemFirstName; }
            set {
                member.MemFirstName = value;
                NotifyPropertyChanged();
            }
        }

        public string MiddleName
        {
            get => member.MemMiddleName;
            set
            {
                member.MemMiddleName = value;
                NotifyPropertyChanged();
            }
        }

        public string LastName
        {   
            get => member.MemLastName;
            set
            {
                member.MemLastName = value;
                NotifyPropertyChanged();
            }
        }

        public MySql.Data.Types.MySqlDateTime DOB
        {
            get => member.MemDOB;
            set
            {
                member.MemDOB = value;
                NotifyPropertyChanged();
            }
        }

        public string PrimAddress
        {
            get => member.MemAddress;
            set
            {
                member.MemAddress = value;
                NotifyPropertyChanged();
            }
        }

        public string SecAddress
        {
            get => member.MemSecAddress;
            set
            {
                member.MemSecAddress = value;
                NotifyPropertyChanged();
            }
        }

        public string PostCode
        {
            get => member.MemPostCode;
            set
            {
                member.MemPostCode = value;
                NotifyPropertyChanged();
            }
        }

        public string City
        {
            get => member.MemCity;
            set
            {
                member.MemCity = value;
                NotifyPropertyChanged();
            }
        }

        public string Email
        {
            get => member.MemEmail;
            set
            {
                member.MemEmail = value;
                NotifyPropertyChanged();
            }
        }

        public string Telephone
        {
            get => member.MemTelephone;
            set
            {
                member.MemTelephone = value;
                NotifyPropertyChanged();
            }
        }

        public string Mobile
        {
            get => member.MemMobile;
            set
            {
                member.MemMobile = value;
                NotifyPropertyChanged();
            }
        }

        #endregion
                

        #region Queries

        public void InsertMemberQuery(TextBox Fname, TextBox Mname, TextBox Lname, DatePicker Dob, TextBox PrimAdd, TextBox SecAdd, TextBox PostCode, TextBox City, TextBox Email, TextBox Telephone, TextBox Mob, ComboBox MemType)
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
            
            string InsertMem = "Insert into Member (Lib_MemberFirstname, Lib_MemberMiddleName, Lib_MemberLastname, Lib_MemberDOB, Lib_MemberAddress, Lib_MemberSecondAddress, Lib_MemberPostCode, Lib_MemberCity, Lib_MemberEmailAddress, Lib_MemberTelephone, Lib_MemberMobile, Lib_MemberTypeName)" +
                               " VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)";
            db.cmd = new MySqlCommand(InsertMem, db.Conn);
            db.cmd.Parameters.AddWithValue("@0", Fname.Text);
            db.cmd.Parameters.AddWithValue("@1", Mname.Text);
            db.cmd.Parameters.AddWithValue("@2", Lname.Text);
            db.cmd.Parameters.AddWithValue("@3", Dob.Text);
            db.cmd.Parameters.AddWithValue("@4", PrimAdd.Text);
            db.cmd.Parameters.AddWithValue("@5", SecAdd.Text);
            db.cmd.Parameters.AddWithValue("@6", PostCode.Text);
            db.cmd.Parameters.AddWithValue("@7", City.Text);
            db.cmd.Parameters.AddWithValue("@8", Email.Text);
            db.cmd.Parameters.AddWithValue("@9", Telephone.Text);
            db.cmd.Parameters.AddWithValue("@10", Mob.Text);
            db.cmd.Parameters.AddWithValue("@11", MemType.Text);
            db.cmd.Prepare();
            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
        }

        
        public void SearchMemByID(TextBox MemID, TextBox Fname, TextBox Mname, TextBox Lname, DatePicker Dob, TextBox PrimAdd, TextBox SecAdd, TextBox PostCode, TextBox City, TextBox Email, TextBox Telephone, TextBox Mob, ComboBox MemType)
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

            string SearchMemQuery = "SELECT Lib_MemberFirstname, Lib_MemberMiddleName, Lib_MemberLastname, Lib_MemberDOB, Lib_MemberAddress, Lib_MemberSecondAddress, Lib_MemberPostCode, Lib_MemberCity, Lib_MemberEmailAddress, Lib_MemberTelephone, Lib_MemberMobile, Lib_MemberTypeName FROM member WHERE Lib_MemberID = @MemID";

            db.cmd = new MySqlCommand(SearchMemQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@MemID", MemID.Text);
                       
            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    Fname.Text = (db.reader["Lib_MemberFirstname"]).ToString();
                    Mname.Text = (db.reader["Lib_MemberMiddleName"]).ToString();
                    Lname.Text = (db.reader["Lib_MemberLastname"]).ToString();
                    Dob.Text = (db.reader["Lib_MemberDOB"]).ToString();
                    PrimAdd.Text = (db.reader["Lib_MemberAddress"]).ToString();
                    SecAdd.Text = (db.reader["Lib_MemberSecondAddress"]).ToString();
                    PostCode.Text = (db.reader["Lib_MemberPostCode"]).ToString();
                    City.Text = (db.reader["Lib_MemberCity"]).ToString();
                    Email.Text = (db.reader["Lib_MemberEmailAddress"]).ToString();
                    Telephone.Text = (db.reader["Lib_MemberTelephone"]).ToString();
                    Mob.Text = (db.reader["Lib_MemberMobile"]).ToString();
                    MemType.Text = (db.reader["Lib_MemberTypeName"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The member ID was incorrect, please make sure that the ID is a number.");
                }
            }
                       
            db.Conn.Close();
            
        }


        public void SearchMemByID(TextBox MemID, TextBox fname, TextBox lname, TextBox mname, TextBox address)
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

            string SearchMemQuery = "SELECT Lib_MemberFirstname, Lib_MemberMiddleName, Lib_MemberLastname, Lib_MemberAddress FROM member WHERE Lib_MemberID = @MemID";

            db.cmd = new MySqlCommand(SearchMemQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@MemID", MemID.Text);

            using (db.reader = db.cmd.ExecuteReader())
            {
                if (db.reader.Read())
                {
                    fname.Text = (db.reader["Lib_MemberFirstname"]).ToString();
                    mname.Text = (db.reader["Lib_MemberMiddleName"]).ToString();
                    lname.Text = (db.reader["Lib_MemberLastname"]).ToString();
                    address.Text = (db.reader["Lib_MemberAddress"]).ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The member ID was incorrect, please make sure that the ID is a number.");
                }

                db.Conn.Close();
            }

        }


        public void UpdateMemberQuery(TextBox MemID, TextBox Fname, TextBox Mname, TextBox Lname, DatePicker Dob, TextBox PrimAdd, TextBox SecAdd, TextBox PostCode, TextBox City, TextBox Email, TextBox Telephone, TextBox Mob, ComboBox MemType)
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
                       

            string UpdateQuery = "UPDATE member SET Lib_MemberFirstname=@0, Lib_MemberMiddleName=@1, Lib_MemberLastname=@2, Lib_MemberDOB=@3, " +
                                 "Lib_MemberAddress=@4, Lib_MemberSecondAddress=@5, Lib_MemberPostCode=@6, Lib_MemberCity=@7, Lib_MemberEmailAddress=@8, " +
                                 "Lib_MemberTelephone=@9, Lib_MemberMobile=@10, Lib_MemberTypeName=@11 WHERE Lib_MemberID = @MemID";
            db.cmd = new MySqlCommand(UpdateQuery, db.Conn);

            db.cmd.Parameters.AddWithValue("@0", Fname.Text);
            db.cmd.Parameters.AddWithValue("@1", Mname.Text);
            db.cmd.Parameters.AddWithValue("@2", Lname.Text);
            db.cmd.Parameters.AddWithValue("@3", Dob.Text);
            db.cmd.Parameters.AddWithValue("@4", PrimAdd.Text);
            db.cmd.Parameters.AddWithValue("@5", SecAdd.Text);
            db.cmd.Parameters.AddWithValue("@6", PostCode.Text);
            db.cmd.Parameters.AddWithValue("@7", City.Text);
            db.cmd.Parameters.AddWithValue("@8", Email.Text);
            db.cmd.Parameters.AddWithValue("@9", Telephone.Text);
            db.cmd.Parameters.AddWithValue("@10", Mob.Text);
            db.cmd.Parameters.AddWithValue("@11", MemType.Text);

            db.cmd.Parameters.AddWithValue("@MemId", MemID.Text);

            db.cmd.ExecuteNonQuery();
            
            db.Conn.Close();
        }

        public void DeleteMemberQuery(TextBox MemberID)
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

            string DeleteQuery = "DELETE FROM MEMBER WHERE Lib_MemberID = @MemberID";

            db.cmd = new MySqlCommand(DeleteQuery, db.Conn);
            db.cmd.Parameters.AddWithValue("@MemberID", MemberID.Text);
            db.cmd.Prepare();
            db.cmd.ExecuteNonQuery();

            db.Conn.Close();
            
        }
        #endregion
    }
}
