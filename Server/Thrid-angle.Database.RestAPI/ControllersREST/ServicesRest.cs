﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Thrid_angle.Database.RestAPI.DTO;
using Thrid_angle.Database.RestAPI.Mehtods;
using Thrid_angle.Database.RestAPI.HttpServices;
using System.Reflection.Metadata.Ecma335;

namespace Thrid_angle.Database.RestAPI.ControllersREST
{
   
    [Route("[controller]/[action]/")]
    [ApiController]
    public class ServicesRest :  ControllerBase, IControllers
    {
        HttpServicesCreateDatabaseUserCard Http;
        MethodsEntityFrameworcSQLite methodsEntityFrameworcSQLite;

      public ServicesRest()
        {
             methodsEntityFrameworcSQLite = new MethodsEntityFrameworcSQLite();
            

        }

        //CreateDatabaseBaskets/{IdUser}/{IdBook}/{QuantityBooks}/{PricePerBook}
        [HttpGet("{IdUser}/{IdBook}/{QuantityBooks}/{PricePerBook}")]
        public void CreateDatabaseBaskets([FromRoute] Guid IdUser, [FromRoute] Guid IdBook, [FromRoute] int QuantityBooks, [FromRoute] int PricePerBook)
        {
            Baskets _baskets = new Baskets();
        
            _baskets.IdUser = IdUser;
            _baskets.IdBook = IdBook;
            _baskets.QuantityBooks = QuantityBooks;
            _baskets.PricePerBook = PricePerBook;
            _baskets.DateCreationBasket = DateTime.Now;
            _baskets.DateUbdateBasket = DateTime.Now;


             methodsEntityFrameworcSQLite.CreateDatabaseBaskets(_baskets);


           



        }

        //ServicesRest/CreateDatabaseBookCard/{NameBook}/{AuthorBook}/{PhotoBook}/{VendorCodeBook}/{GenreBook}/{DescriptionBook}/{PriceBook}
        [HttpGet("{NameBook}/{AuthorBook}/{PhotoBook}/{VendorCodeBook}/{GenreBook}/{DescriptionBook}/{PriceBook}")]
        public void CreateDatabaseBookCard([FromRoute] string NameBook, [FromRoute] string AuthorBook, [FromRoute] int PhotoBook, [FromRoute] string VendorCodeBook, [FromRoute] string GenreBook, [FromRoute] string DescriptionBook, [FromRoute] decimal PriceBook)
        {

            BookCard bookCard = new BookCard();

            bookCard.NameBook = NameBook;
            bookCard.AuthorBook = AuthorBook;
            bookCard.PhotoBook = PhotoBook;
            bookCard.VendorCodeBook = VendorCodeBook;
            bookCard.RecieptDateBook = DateTime.Now;
            bookCard.GenreBook = GenreBook;
            bookCard.DescriptionBook = DescriptionBook;
            bookCard.PriceBook = PriceBook;
            bookCard.DateCreationBook = DateTime.Now;
            bookCard.DateUpdateBook = DateTime.Now;


            methodsEntityFrameworcSQLite.CreateDatabaseBookCard(bookCard);

            

        }

        //ServicesRest/CreateDatabaseOrderCard{OrderCardBooksList}/{StatusOrderCard}/{IdUsers}/
        [HttpGet("{OrderCardBooksList}/{StatusOrderCard}/{IdUsers}")]
        public void CreateDatabaseOrderCard([FromRoute] String OrderCardBooksList,  [FromRoute] string StatusOrderCard, [FromRoute] Guid IdUsers)
        {
            OrderCard orderCard = new OrderCard();

            orderCard.OrderCardBooksList = OrderCardBooksList;
            orderCard.DateCreationOrderCard = DateTime.Now;
            orderCard.DateUpdateOrderCard = DateTime.Now;
            orderCard.StatusOrderCard = StatusOrderCard;
            orderCard.IdUsers = IdUsers;
            methodsEntityFrameworcSQLite.CreateDatabaseOrderCard(orderCard);

            

        }

        //ServicesRest/CreateDatabaseQuoteCard/{QuoteTitle}/{QuoteText}/{QuoteAutor}
        [HttpGet("{QuoteTitle}/{QuoteText}/{QuoteAutor}")]
        public void CreateDatabaseQuoteCard([FromRoute] string QuoteTitle, [FromRoute] string QuoteText, [FromRoute] string QuoteAutor)
        {

           QuoteCard quoteCard = new QuoteCard();

            quoteCard.QuoteTitle = QuoteTitle;
            quoteCard.QuoteText = QuoteText;
            quoteCard.QuoteAutor = QuoteAutor;
            quoteCard.DateCreationQuote = DateTime.Now;
            quoteCard.DateUpdateQuote = DateTime.Now;

            methodsEntityFrameworcSQLite.CreateDatabaseQuoteCard(quoteCard);

            
        }


        //ServicesRest/CreateDatabaseRequestCard/{CommentTextCard}/{NumberStars}/{IdUser}/{IdBook}
        [HttpGet("{CommentTextCard}/{NumberStars}/{IdUser}/{IdBook}")]
        public void CreateDatabaseRequestCard([FromRoute] string CommentTextCard, [FromRoute] int NumberStars, [FromRoute] Guid IdUser, [FromRoute] Guid IdBook)
        {

            RequestCard requestCard = new RequestCard();

            requestCard.CommentTextCard = CommentTextCard;
            requestCard.NumberStars = NumberStars;
            requestCard.IdUser = IdUser;
            requestCard.IdBook = IdBook;
            requestCard.DateRequestCreation = DateTime.Now;
            requestCard.DateRequestUpdation = DateTime.Now;

            methodsEntityFrameworcSQLite.CreateDatabaseRequestCard(requestCard);

            
        }


        //ServicesRest/CreateDatabaseUserCard/{UserName}/{SurnameUser}/{RoleUser}/{FloorUser}/{AgeUser}/{AddressUser}/{TelephoneUser}/{EmailUser}/{LoginUser}/{PasswordUser}
        [HttpGet("{UserName}/{SurnameUser}/{RoleUser}/{FloorUser}/{AgeUser}/{AddressUser}/{TelephoneUser}/{EmailUser}/{LoginUser}/{PasswordUser}")]
        public void CreateDatabaseUserCard([FromRoute] string UserName, [FromRoute] string SurnameUser, [FromRoute] string RoleUser, [FromRoute] string FloorUser, [FromRoute] int AgeUser, [FromRoute] string AddressUser, [FromRoute] string TelephoneUser, [FromRoute] string EmailUser, [FromRoute] string LoginUser, [FromRoute] string PasswordUser)
        {

            UserCard userCard = new UserCard();

            userCard.UserName = UserName;
            userCard.SurnameUser = SurnameUser;
            userCard.RoleUser = RoleUser;
            userCard.FloorUser = FloorUser;
            userCard.AgeUser = AgeUser;
            userCard.AddressUser = AddressUser;
            userCard.TelephoneUser = TelephoneUser;
            userCard.EmailUser = EmailUser;
            userCard.LoginUser = LoginUser;
            userCard.PasswordUser = PasswordUser;
            userCard.DateCreationUser = DateTime.Now;   
            userCard.UpdateDateUser = DateTime.Now;

            methodsEntityFrameworcSQLite.CreateDatabaseUserCard(userCard);

            Console.WriteLine(userCard.AddressUser);
            

        }

        //ServicesRest/IDReadDatabaseBaskets/{IdBasket}
        [HttpGet("{IdBasket}")]
        public Baskets IDReadDatabaseBaskets([FromRoute]  Guid IdBasket)

        {
            Baskets baskets = methodsEntityFrameworcSQLite.IDReadDatabaseBaskets(IdBasket);
            return baskets;

        }

        //ServicesRest/IDReadDatabaseBookCard/{IdBook}
        [HttpGet("{IdBook}")]
        public BookCard IDReadDatabaseBookCard([FromRoute] Guid IdBook)
        {
            BookCard bookCard = methodsEntityFrameworcSQLite.IDReadDatabaseBookCard(IdBook);
            return bookCard;

        }

        //ServicesRest/IDReadDatabaseOrderCard/{IdOrder}
        [HttpGet("{IdOrder}")]
        public OrderCard IDReadDatabaseOrderCard([FromRoute] Guid IdOrder)
        {
            OrderCard orderCard = methodsEntityFrameworcSQLite.IDReadDatabaseOrderCard(IdOrder);
            return orderCard;

        }

        //ServicesRest/IDReadDatabaseQuoteCard/{IdQuote}
        [HttpGet("{IdQuote}")]
        public QuoteCard IDReadDatabaseQuoteCard([FromRoute] Guid IdQuote)
        {
            QuoteCard quoteCard = methodsEntityFrameworcSQLite.IDReadDatabaseQuoteCard(IdQuote);
            return quoteCard;

        }
        //ServicesRest/IDReadDatabaseRequestCard/{IdRequestCard}
        [HttpGet("{IdRequestCard}")]
        public RequestCard IDReadDatabaseRequestCard([FromRoute] Guid IdRequestCard)
        {
            RequestCard requestCard = methodsEntityFrameworcSQLite.IDReadDatabaseRequestCard(IdRequestCard);
            return requestCard;

        }
        //ServicesRest/IDReadDatabaseUserCard/{IdUser}
        [HttpGet("{IdUser}")]
        public UserCard IDReadDatabaseUserCard([FromRoute] Guid IdUser)
        {
            UserCard userCard = methodsEntityFrameworcSQLite.IDReadDatabaseUserCard(IdUser);
            return userCard;

        }
        //ServicesRest/UpdateDatabaseBaskets/{IdBasket}/{QuantityBooks}/{PricePerBook}
        [HttpGet("{IdBasket}/{QuantityBooks}/{PricePerBook}")]
        public void UpdateDatabaseBaskets([FromRoute] Guid IdBasket, [FromRoute] int QuantityBooks, [FromRoute] int PricePerBook)
        {
            Baskets baskets = new Baskets();

            baskets.IdBasket = IdBasket;
            baskets.QuantityBooks = QuantityBooks;
            baskets.PricePerBook = PricePerBook;
            baskets.DateUbdateBasket = DateTime.Now;
            methodsEntityFrameworcSQLite.UpdateDatabaseBaskets(baskets);

           

        }



        //ServicesRest/UpdateDatabaseBookCard/{IdBook}/{NameBook}/{AuthorBook}/{PhotoBook}/{VendorCodeBook}/{GenreBook}/{DescriptionBook}/{PriceBook}
        [HttpGet("{IdBook}/{NameBook}/{AuthorBook}/{PhotoBook}/{VendorCodeBook}/{GenreBook}/{DescriptionBook}/{PriceBook}")]
       public void UpdateDatabaseBookCard([FromRoute] Guid IdBook, [FromRoute] string NameBook, [FromRoute] string AuthorBook, [FromRoute] int PhotoBook, [FromRoute] string VendorCodeBook,  [FromRoute] string GenreBook, [FromRoute] string DescriptionBook, [FromRoute] decimal PriceBook)
       {
           BookCard bookCard = new BookCard();
            bookCard.IdBook = IdBook;
            bookCard.NameBook = NameBook;
            bookCard.AuthorBook = AuthorBook;
            bookCard.PhotoBook = PhotoBook;
            bookCard.VendorCodeBook = VendorCodeBook;
            bookCard.RecieptDateBook = DateTime.Now;
            bookCard.GenreBook = GenreBook;
            bookCard.DescriptionBook = DescriptionBook;
            bookCard.PriceBook = PriceBook;
            bookCard.DateUpdateBook = DateTime.Now;

            methodsEntityFrameworcSQLite.UpdateDatabaseBookCard(bookCard);

           
       }
        //ServicesRest/UpdateDatabaseOrderCard/{IdOrder}/{OrderCardBooksList}/StatusOrderCard}
        [HttpGet("{IdOrder}/{OrderCardBooksList}/{StatusOrderCard}")]
       public void UpdateDatabaseOrderCard([FromRoute] Guid IdOrder, [FromRoute] String OrderCardBooksList, [FromRoute] string StatusOrderCard)
       {

           OrderCard orderCard = new OrderCard();

            orderCard.IdOrder = IdOrder;
            orderCard.OrderCardBooksList = OrderCardBooksList;
            orderCard.DateUpdateOrderCard = DateTime.Now        ;
            orderCard.StatusOrderCard = StatusOrderCard;


            methodsEntityFrameworcSQLite.UpdateDatabaseOrderCard(orderCard);
           
     
       }

        //ServicesRest/UpdateDatabaseQuoteCard/{IdQuote}/{QuoteTitle}/{QuoteText}/{QuoteAutor}
        [HttpGet("{IdQuote}/{QuoteTitle}/{QuoteText}/{QuoteAutor}")]
       public void UpdateDatabaseQuoteCard([FromRoute] Guid IdQuote, [FromRoute] string QuoteTitle, [FromRoute] string QuoteText, [FromRoute] string QuoteAutor)
       {
           QuoteCard quoteCard = new QuoteCard();

            quoteCard.IdQuote = IdQuote;
            quoteCard.QuoteTitle = QuoteTitle;
            quoteCard.QuoteText = QuoteText;
            quoteCard.QuoteAutor = QuoteAutor;
            quoteCard.DateUpdateQuote = DateTime.Now;   

            methodsEntityFrameworcSQLite.UpdateDatabaseQuoteCard(quoteCard);

           
     
       }

        //ServicesRest/UpdateDatabaseRequestCard/{IdRequestCard}/{CommentTextCard}/{NumberStars}
        [HttpGet("{IdRequestCard}/{CommentTextCard}/{NumberStars}")]
       public void UpdateDatabaseRequestCard([FromRoute] Guid IdRequestCard, [FromRoute] string CommentTextCard, [FromRoute] int NumberStars)
       {
           RequestCard requestCard = new RequestCard();

            requestCard.IdRequestCard = IdRequestCard;
            requestCard.CommentTextCard = CommentTextCard;
            requestCard.NumberStars = NumberStars;
            requestCard.DateRequestUpdation = DateTime.Now;

            methodsEntityFrameworcSQLite.UpdateDatabaseRequestCard(requestCard);

           
       }
        //ServicesRest/UpdateDatabaseUserCard/{IdUser}/{UserName}/{SurnameUser}/{RoleUser}/{FloorUser}/{AgeUser}/{AddressUser}/{TelephoneUser}/{EmailUser}/{LoginUser}/{PasswordUser}
        [HttpGet("{IdUser}/{UserName}/{SurnameUser}/{RoleUser}/{FloorUser}/{AgeUser}/{AddressUser}/{TelephoneUser}/{EmailUser}/{LoginUser}/{PasswordUser}")]
       public void UpdateDatabaseUserCard([FromRoute] Guid IdUser, [FromRoute] string UserName, [FromRoute] string SurnameUser, [FromRoute] string RoleUser, [FromRoute] string FloorUser, [FromRoute] int AgeUser, [FromRoute] string AddressUser, [FromRoute] string TelephoneUser, [FromRoute] string EmailUser, [FromRoute] string LoginUser, [FromRoute] string PasswordUser)
       {
           UserCard userCard = new UserCard();

            userCard.IdUser = IdUser;
            userCard.UserName = UserName;
            userCard.SurnameUser = SurnameUser;
            userCard.RoleUser = RoleUser;
            userCard.FloorUser = FloorUser;
            userCard.AgeUser = AgeUser;
            userCard.AddressUser = AddressUser;
            userCard.TelephoneUser = TelephoneUser;
            userCard.EmailUser = EmailUser;
            userCard.LoginUser = LoginUser;
            userCard.PasswordUser = PasswordUser;
            userCard.UpdateDateUser = DateTime.Now; 

            methodsEntityFrameworcSQLite.UpdateDatabaseUserCard(userCard);
           
          
       }
        //ServicesRest/DeleteDatabaseBaskets/{IdBasket}
        [HttpGet("{IdBasket}")]
       public void DeleteDatabaseBaskets([FromRoute] Guid IdBasket)
       {
           
            methodsEntityFrameworcSQLite.DeleteDatabaseBaskets(IdBasket);
          
     
       }
        //ServicesRest/DeleteDatabaseBookCard/{IdBook}
        [HttpGet("{IdBook}")]
       public void DeleteDatabaseBookCard([FromRoute] Guid IdBook)
       {
           
            methodsEntityFrameworcSQLite.DeleteDatabaseBookCard(IdBook);
           
       }
        //ServicesRest/DeleteDatabaseOrderCard/{IdOrder}
        [HttpGet("{IdOrder}")]
       public void DeleteDatabaseOrderCard([FromRoute] Guid IdOrder)
       {
           
            methodsEntityFrameworcSQLite.DeleteDatabaseOrderCard(IdOrder);
           
     
       }
        //ServicesRest/DeleteDatabaseQuoteCard/{IdQuote}
        [HttpGet("{IdQuote}")]
        public void DeleteDatabaseQuoteCard([FromRoute] Guid IdQuote)
        {
            methodsEntityFrameworcSQLite.DeleteDatabaseQuoteCard(IdQuote);
        }


        //ServicesRest/DeleteDatabaseRequestCard/{IdRequestCard}
        [HttpGet("{IdRequestCard}")]
       public void DeleteDatabaseRequestCard([FromRoute] Guid IdRequestCard) 
       {
            methodsEntityFrameworcSQLite.DeleteDatabaseRequestCard(IdRequestCard);

     
     
       }
        //ServicesRest/DeleteDatabaseUserCard/{IdUser}
        [HttpGet("{IdUser}")]
       public   void DeleteDatabaseUserCard([FromRoute] Guid IdUser)
       {

            methodsEntityFrameworcSQLite.DeleteDatabaseUserCard(IdUser);
          
        }


        // UserReadDatabaseBaskets/{IdUser} - читате содержание корзины по IdUser индивикатору записи БД User-а
        [HttpGet("{IdUser}")]
        public IEnumerable<Baskets> UserReadDatabaseBaskets([FromRoute] Guid IdUser)
        {

            List<Baskets> t = methodsEntityFrameworcSQLite.UserReadDatabaseBaskets(IdUser);

            foreach (Baskets m in t) { yield return m;  }

            
            

        }

        //ReadDatabaseBookCard - читает весь список книг (парметры не нужны)
        [HttpGet()]
        public IEnumerable<BookCard> ReadDatabaseBookCard()
        {
            List<BookCard> t = methodsEntityFrameworcSQLite.ReadDatabaseBookCard();

            foreach (BookCard m in t) { yield return m; }



        }

        //UserReadDatabaseOrderCard/{IdUser}  - читатет карточку заказа по IdUser пользователя
        [HttpGet("{IdUser}")]
        public IEnumerable<OrderCard> UserReadDatabaseOrderCard([FromRoute] Guid IdUser)

        {

            List<OrderCard> t = methodsEntityFrameworcSQLite.UserReadDatabaseOrderCard(IdUser);

            foreach (OrderCard m in t) { yield return m; }



        }

        //IdUserReadDatabaseRequestCard/{IdUser} - читатет карточку запроса по IdUser 
        [HttpGet("{IdUser}")]
        public IEnumerable<RequestCard> IdUserReadDatabaseRequestCard([FromRoute] Guid IdUser) 
        {

            List<RequestCard> t = methodsEntityFrameworcSQLite.IdUserReadDatabaseRequestCard(IdUser);

            foreach (RequestCard m in t) { yield return m; }



        }

        //IdBookReadDatabaseRequestCard/{IdBook}  - читатет карточку запроса по IdBook
        [HttpGet("{IdBook}")]
        public IEnumerable<RequestCard> IdBookReadDatabaseRequestCard([FromRoute] Guid IdBook)
        {

            List<RequestCard> t = methodsEntityFrameworcSQLite.IdBookReadDatabaseRequestCard(IdBook);

            foreach (RequestCard m in t) { yield return m; }


        }

        //LoginUserReadDatabaseUserCard/{LoginUser}/{PasswordUser} - Читатет карточку запроса по Логину и Паролю User
        [HttpGet("{LoginUser}/{PasswordUser}")]
        public IEnumerable<UserCard> LoginUserReadDatabaseUserCard([FromRoute] string LoginUser, [FromRoute] string PasswordUser) 
        {

            List<UserCard> t = methodsEntityFrameworcSQLite.LoginUserReadDatabaseUserCard(LoginUser, PasswordUser);

            foreach (UserCard m in t) { yield return m; }

        }




    }
}
