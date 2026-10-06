using Library;

Book Book = new Book();

// this is info for the book class
Book.Title = "The Great Gatsby";
Book.Author = "Scooby Doo";
Book.ISBN = "978-0-7432-4522-4";
Book.DisplayInfo();

//Add a another book
Book AnotherBook = new Book("To Kill a Mockingbird", "wood Lee", "978-0-06-112008-4");
AnotherBook.DisplayInfo();