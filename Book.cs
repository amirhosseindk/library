using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    class Book:DB
    {
        public int num;
        public string name;
        public string writer;
        public string cat;


        public void AddBook()
        {
            base.connect();
            string Addqr = "insert into book(num, bname, writer, cat) values('{0}','{1}','{2}','{3}')";
            Addqr = string.Format(Addqr, num, name, writer, cat);
            base.Perform(Addqr);
            base.disconnect();
        }


        public void EditBook()
        {
            base.connect();
            string saveqr = "update book set bname='{0}',writer='{1}',cat='{2}' where num={3}";
            saveqr = string.Format(saveqr, name, writer, cat, num);
            base.Perform(saveqr);
            base.disconnect();
        }

        public void BorrowBook(string person,string date)
        {
            base.connect();
            string saveqr = "update book set borrow='{0}' where num={1}";
            string Addqr = "insert into borrow(num, dateb, person) values({0},'{1}','{2}')";
            saveqr = string.Format(saveqr, true, num);
            Addqr = string.Format(saveqr, num, date, person);
            base.Perform(saveqr);
            base.Perform(Addqr);
            base.disconnect();
        }

        public void LendBook(string person, string date)
        {
            base.connect();
            string saveqr = "update book set borrow='{0}' where num={1}";
            string Addqr = "update borrow set datel='{0}' where person='{1}'";
            saveqr = string.Format(saveqr, false, num);
            Addqr = string.Format(saveqr,date, person);
            base.Perform(saveqr);
            base.Perform(Addqr);
            base.disconnect();
        }

        public DataTable SearchBook(string s)
        {
            base.connect();
            string qrselect = "select * from book where bname='{0}'";
            qrselect = string.Format(qrselect, s);
            DataTable mydt = base.Searchdb(qrselect);
            base.disconnect();
            return mydt;
        }

        public DataTable SelectBook()
        {
            base.connect();
            string qrselect = "select * from book";
            DataTable mydt = base.Searchdb(qrselect);
            base.disconnect();
            return mydt;
        }

        public void DeleteBook()
        {
            base.connect();
            string delqr = "delete from book where num='{0}'";
            delqr = string.Format(delqr, num);
            base.Perform(delqr);
            base.disconnect();
        }
    }
}
