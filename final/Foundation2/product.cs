using System;


public class product {
        private  int product_price;
        private string product_name;
        private int product_quantity;


     public void   choose_product_name () {
     Console.WriteLine ("1. choose product name?");
      product_name = Console.ReadLine ();

}

        public  void  choose_product_price() {
                Console.WriteLine("2.choose the product price?");
                 product_price = Console.Read();
               
        }

        public void choose_product_quantity() {
                Console.WriteLine("3.choose the product quantity?");
                 product_quantity = Console.Read();
                
        }

        public product( ) {
                choose_product_price();
                choose_product_name();
                choose_product_quantity();
          

        
        }
        public int  GetPrice (){
                return product_price;
        }
        public int  GetTotalPrice (){
                return product_price*product_quantity;
}

}