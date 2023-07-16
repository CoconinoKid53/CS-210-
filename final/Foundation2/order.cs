using System;



class Order {
   private  int total_cost_item;

 private   List <product> listofoproducts;
         public  Order () {

                listofoproducts = new List<product>();


            Console.Write("Please enter filename--> ");
                        string fileName = Console.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(fileName);
                        foreach (string line in lines) {
                            string[] parts = line.Split(",");

                            int points = int.Parse(parts[0]);
                            string choose_product_name = parts[1];
                            string choose_product_price = parts[2];
                            string choose_product_quantity = parts[3];
                            string enter_customer_country_name = parts[4];
                            string enter_customer_city_name = parts[5];
                          string load_oder_file = parts[6];     }
            }

                            
                        


                           private  int total_price(){
                            return total_cost_item;
                           }
                          


}
                                    
                                

                            




                    