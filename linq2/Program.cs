namespace linq2
{
    internal class Program
    {
                        //Sorting using linq (Query and non-query syntax )
        public class Book
        {


            public int id { get; set; }
            public string name { get; set; }
            public string author { get; set; }

        }

        static void Main(string[] args)
        {
            Book[] books = {

                new Book(){id=1,name="web", author="david"},
                new Book(){id=2,name="mobile",author="osama"},
                new Book(){id=3,name="ai", author="ahmed"}
            
            };
                      // using query syntax to sort them

            var list=from item in books 
                     orderby item.id
                     select item;

                    //Non-Query syntax

          //  var list2 = books.OrderByDescending(item => item.id).ThenBy(item=>item.Title);

            foreach (var  item in list)
            {
                Console.WriteLine("{id={0} , name={1} , author={2}",item.id,item.name,item.author);
            }
        }
    }
}