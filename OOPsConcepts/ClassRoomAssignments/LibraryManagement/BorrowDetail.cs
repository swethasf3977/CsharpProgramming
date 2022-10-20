using System;
namespace LibraryManagement
{  

    public class BorrowDetail
    {
        private static int s_borrowId = 300;
        public string BorrowId { get; }
        public string BookId { get; set; }
        public string RegistrationId { get; set; }
        public DateTime DateofBorrow { get; set; }
       

       public BorrowDetail(string bookId,string registrationId,DateTime dateofOrder)
       {
        s_borrowId++;
        BorrowId = "BID"+s_borrowId;

        BookId = bookId;
        RegistrationId = registrationId;
        DateofBorrow = dateofOrder;

       }

       
    }
}