using System;



public class address {
    private string country_name;
    private string city_name;


    public string enter_customer_country_name() {
        Console.WriteLine("4.what is your country?");
         country_name = Console.ReadLine();
        return country_name;





    }
         public string get_country_name (){
                return country_name;
        }

        public string get_city_name() {
            return city_name;
        }



    public string enter_customer_city_name() {
        Console.WriteLine("5.what is your city?");
        string address_name = Console.ReadLine();
        return address_name;
    }
}