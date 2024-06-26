namespace BigCommerce_Server.Models

{
    public class ShippingAddress
    {
        public int id;
        public int order_id;
        public String first_name;
        public String last_name;
        public String company;
        public String street_1;
        public String city;
        public String zip;
        public String state;
        public String country;
        public String email;
        public String phone;
        public int items_total;
        public String shipping_method;
        public String cost_ex_tax;
    }
}
